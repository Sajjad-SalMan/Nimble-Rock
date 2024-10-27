using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Coin_Movement : MonoBehaviour
{
    [SerializeField] private float scaleTime = 1f;
    [SerializeField] private Vector3 size;

    [SerializeField] private float startDelay;
    [SerializeField] private float duration;
    [SerializeField] private float loopDelay;
    [SerializeField] private Ease ease;

    [SerializeField] private PathMode pathMode;
    [SerializeField] private PathType pathType;
    [SerializeField] private Vector3[] path;

    private ParticleSystem[] particle;
    private SpriteRenderer sprite;
    private UnityEngine.Rendering.Universal.Light2D pointLight;
    private BoxCollider2D collider2d;

    private void Start()
    {
        StartCoroutine(Waitsequance());

        transform.DOScale(size, scaleTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);

        particle = GetComponentsInChildren<ParticleSystem>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        pointLight = GetComponentInChildren<UnityEngine.Rendering.Universal.Light2D>();
        collider2d = GetComponent<BoxCollider2D>();
    }
    void Movement()
    {
        Sequence move = DOTween.Sequence();

        move.SetDelay(loopDelay);
        move.Append(transform.DOPath(path, duration, pathType, pathMode, 10).SetEase(ease));
        move.AppendInterval(loopDelay);
        move.SetLoops(-1, LoopType.Yoyo) ;
    }
    private IEnumerator Waitsequance()
    {
        yield return new WaitForSeconds(startDelay);
        Movement();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(PlayandDistroy());
        }
    }
    IEnumerator PlayandDistroy()
    {
        foreach(var p in particle)
        {
            p.Play();
        }
        sprite.enabled = false;
        pointLight.enabled = false;
        collider2d.enabled = false;
        yield return new WaitForSeconds(.5f);
        Destroy(this.gameObject);
    }
}
