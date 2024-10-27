using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RevivePosition : MonoBehaviour
{
    private Vector3 lastCheckPoint;

    private PlayerController playerController;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private TrailRenderer trail;

    private GameObject checkpoint1;
    private GameObject checkpoint2;
    public ParticleSystem deathEffect;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        trail = GetComponentInChildren<TrailRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "CheckPoint")
        {
            lastCheckPoint = collision.gameObject.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "CheckPoint" && SceneManager.GetActiveScene().buildIndex == 21)
        {
            StartCoroutine(DelayCheckpointActive());
            checkpoint2 = collision.gameObject.transform.GetChild(0).gameObject;
            checkpoint1 = collision.gameObject.transform.GetChild(1).gameObject;
        }
        
    }

    public void SetPos()
    {
        transform.position = lastCheckPoint;
        StartCoroutine(TurningPlayerOn());
    }

    private IEnumerator TurningPlayerOn()
    {
        deathEffect.Play();
        yield return new WaitForSeconds(.6f);
        playerController.enabled = true;
        rb.simulated = true;
        sprite.enabled = true;
        trail.emitting = true;
    }

    private IEnumerator DelayCheckpointActive()
    {
        yield return new WaitForSeconds(1f);
        checkpoint1.SetActive(true);
        checkpoint2.SetActive(true);
    }
}
