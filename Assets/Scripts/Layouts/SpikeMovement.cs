using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpikeMovement : MonoBehaviour
{
    public float duration;
    public PathType pathType;
    public PathMode pathMode;
    public Ease ease;
    public Vector3[] path;

    [SerializeField] private bool EndlessMode = false;

    private void Start()
    {
        Pathway();
    }
    void Pathway()
    {
        if (!EndlessMode)
        {
            transform.DOPath(path, duration, pathType, pathMode, 10).SetLoops(-1, LoopType.Yoyo).SetEase(ease);

        }
        if (EndlessMode)
        {
            transform.DOLocalPath(path, duration, pathType, pathMode, 10).SetLoops(-1, LoopType.Yoyo).SetEase(ease);
        }
    }
}
