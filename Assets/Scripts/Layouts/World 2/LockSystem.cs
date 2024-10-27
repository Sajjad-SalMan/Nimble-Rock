using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LockSystem : MonoBehaviour
{
    private bool hasKey;

    public GameObject key;
    public GameObject locker;

    [Header ("Key")]
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;
    public Vector3 minValue, maxValue;

    private bool equiped;
    public ParticleSystem[] particles;

    [Header("Lock")]
    public Animator animator;
    public GameObject sprites;
    private BoxCollider2D Collider2D;

    private void Start()
    {
        Collider2D = GetComponent<BoxCollider2D>();
    }
    private void FixedUpdate()
    {
        if (equiped)
        {
            Follow();
            GetComponent<CircleCollider2D>().enabled = false;
        }
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 boundPosition = new Vector3(
            Mathf.Clamp(targetPosition.x, minValue.x, maxValue.x),
            Mathf.Clamp(targetPosition.y, minValue.y, maxValue.y),
            Mathf.Clamp(targetPosition.z, minValue.z, maxValue.z));
        Vector3 smoothPosition = Vector3.Lerp(key.transform.position, boundPosition, smoothFactor * Time.fixedDeltaTime);
        key.transform.position = smoothPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hasKey = true;
            foreach (var particle in particles)
            {
                particle.Play();
            }
            AudioManager.instance.Play("Key");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            equiped = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (hasKey)
            {
                StartCoroutine(OpenLock());
            }
        }
    }

    private IEnumerator OpenLock()
    {
        animator.SetTrigger("Start");
        sprites.transform.DOScale(0, 0.33f).SetEase(Ease.InOutBounce);
        key.SetActive(false);
        foreach (var particle in particles)
        {
            particle.Stop();
        }
        yield return new WaitForSeconds(0.33f);
        sprites.SetActive(false);
        locker.SetActive(false);
        Collider2D.enabled = false;
        AudioManager.instance.Play("Door");
    }
}
