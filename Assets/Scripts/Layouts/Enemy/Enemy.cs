using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float moveduration;
    [SerializeField] private float rotduration;
    [SerializeField] private float delay;
    [SerializeField] private float startdelay;
    public LoopType loopType = LoopType.Yoyo;

    public PathType pathType;
    public PathMode pathMode;
    public Ease ease;
    public Vector3[] path;

    [SerializeField]
    public bool hasRotation = true;
    [SerializeField] private bool EndlessMode = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Waitsequance());
    }
    void Movement()
    {
        Sequence move = DOTween.Sequence();

        move.SetDelay(delay);
        move.Append(transform.DOPath(path, moveduration, pathType, pathMode, 10).SetEase(ease));
        move.AppendInterval(delay);
        move.SetLoops(-1, loopType);
    }
    void Rotation()
    {
        if (hasRotation)
        {
            Sequence rotate = DOTween.Sequence();

            rotate.SetDelay(delay);
            rotate.Append(transform.DORotate(new Vector3(0, 0, 360), rotduration, RotateMode.FastBeyond360).SetEase(ease));
            rotate.AppendInterval(delay);
            rotate.SetLoops(-1, LoopType.Restart);
        }
        else
        {
            return;
        }
    }
    private IEnumerator Waitsequance()
    {
        yield return new WaitForSeconds(startdelay);
        if (!EndlessMode)
        {
            Movement();
            Rotation();
        }
        if (EndlessMode)
        {
            LocalMovement();
            LocalRotation();
        }
    }

    void LocalMovement()
    {
        Sequence move = DOTween.Sequence();

        move.SetDelay(delay);
        move.Append(transform.DOLocalPath(path, moveduration, pathType, pathMode, 10).SetEase(ease));
        move.AppendInterval(delay);
        move.SetLoops(-1, loopType);
    }
    void LocalRotation()
    {
        Sequence rotate = DOTween.Sequence();

        rotate.SetDelay(delay);
        rotate.Append(transform.DOLocalRotate(new Vector3(0, 0, 360), rotduration, RotateMode.FastBeyond360).SetEase(ease));
        rotate.AppendInterval(delay);
        rotate.SetLoops(-1, LoopType.Restart);
    }
}
