using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Checkpoint : MonoBehaviour
{
    public GameObject leftLight;
    public GameObject rightLight;
    public GameObject line;

    [SerializeField] private float duration;
    [SerializeField] private float scale;
    private ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        particle.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator LightAnimation()
    {
        leftLight.transform.DOScaleX(scale, duration);
        rightLight.transform.DOScaleX(scale, duration);
        line.transform.DOScaleY(0, .1f);
        yield return new WaitForSeconds(.1f);
        particle.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        particle.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(LightAnimation());
            AudioManager.instance.Play("CheckPoint");
        }
    }
}
