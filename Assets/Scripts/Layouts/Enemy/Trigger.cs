using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Trigger : MonoBehaviour
{
    [SerializeField] private float duration;
    [SerializeField]  private Ease ease;
    [SerializeField] private float delay;
    [SerializeField]  private Vector3[] path1;
    [SerializeField] private Vector3[] path2;
    public GameObject[] enemy;

    [SerializeField] private bool EndlessMode = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (!EndlessMode)
            {
                //enemy[0].transform.DOPath(path1, duration, PathType.Linear, PathMode.Ignore).SetEase(ease);
                Movement();
                if(1 < enemy.Length)
                {
                    Movement2();
                }
            }
            if (EndlessMode)
            {
                LocalMovement();
                if (1 < enemy.Length)
                {
                    LocalMovement2();
                }
            }
        }
    }

    void Movement()
    {
        Sequence move = DOTween.Sequence();

        move.Append(enemy[0].transform.DOPath(path1, duration, PathType.Linear, PathMode.Ignore, 10).SetEase(ease));
        move.AppendInterval(delay);
        move.SetLoops(2, LoopType.Yoyo);
    }
    void Movement2()
    {
        Sequence move = DOTween.Sequence();

        move.Append(enemy[1].transform.DOPath(path2, duration, PathType.Linear, PathMode.Ignore, 10).SetEase(ease));
        move.AppendInterval(delay);
        move.SetLoops(2, LoopType.Yoyo);
    }
    void LocalMovement()
    {
        Sequence move = DOTween.Sequence();

        move.Append(enemy[0].transform.DOLocalPath(path1, duration, PathType.Linear, PathMode.Ignore, 10).SetEase(ease));
        move.AppendInterval(delay);
        move.SetLoops(2, LoopType.Yoyo);
    }
    void LocalMovement2()
    {
        Sequence move = DOTween.Sequence();

        move.Append(enemy[1].transform.DOLocalPath(path2, duration, PathType.Linear, PathMode.Ignore, 10).SetEase(ease));
        move.AppendInterval(delay);
        move.SetLoops(2, LoopType.Yoyo);
    }
}
