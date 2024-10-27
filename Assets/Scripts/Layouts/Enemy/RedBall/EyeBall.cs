using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EyeBall : MonoBehaviour
{
    public Animator animator;
    private GameObject player;
    private PlayerController playerController;
    private Transform target;

    private bool isbottom;
    [SerializeField] private bool chase = true;
    [SerializeField] private Vector3[] leftpath;
    [SerializeField] private Vector3[] rightpath;
    [SerializeField] private float duration;
    [SerializeField] private float delay;
    [SerializeField] private Ease ease;
    private PathMode pathMode;
    private PathType pathType;

    private bool doOnce;

    [SerializeField] private bool endless = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerController>();
        target = player.GetComponent<Transform>();
        doOnce = true;
    }

    private void Update()
    {
        if (isbottom)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, 10 * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           if (!playerController.grounded && doOnce && chase)
            {
                animator.SetTrigger("BottomTrigger");
                isbottom = true;
                doOnce = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (playerController.jumpforce > 0 && playerController.grounded && doOnce)
            {
                animator.SetTrigger("LeftTrigger");
                LeftMovement();
                doOnce = false;
                AudioManager.instance.Play("Alert");
            }
            if (playerController.jumpforce < 0 && playerController.grounded && doOnce)
            {
                animator.SetTrigger("RightTrigger");
                RightMovement();
                doOnce = false;
                AudioManager.instance.Play("Alert");
            }
        }

    }

    void LeftMovement()
    {
        Sequence move = DOTween.Sequence();

        move.SetDelay(delay);
        if (!endless)
        {
            move.Append(transform.DOPath(leftpath, duration, pathType, pathMode, 10).SetEase(ease));
        }
        if (endless)
        {
            move.Append(transform.DOLocalPath(leftpath, duration, pathType, pathMode, 10).SetEase(ease));
        }
    }
    void RightMovement()
    {
        Sequence move = DOTween.Sequence();

        move.SetDelay(delay); if (!endless)
        {
            move.Append(transform.DOPath(rightpath, duration, pathType, pathMode, 10).SetEase(ease));
        }
        if (endless)
        {
            move.Append(transform.DOLocalPath(rightpath, duration, pathType, pathMode, 10).SetEase(ease));
        }
    }
}
