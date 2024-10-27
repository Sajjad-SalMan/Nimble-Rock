using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotation_Movement : MonoBehaviour
{
    [Header("Rotation")]
    [SerializeField] private float rotduration;
    [SerializeField] private float rotationAmount;
    [SerializeField] private float rotDelay;
    [Header("Movement")]
    [SerializeField] private float moveduration;
    [SerializeField] private float startdelay;
    [SerializeField] private float loopDelay;
    public LoopType loopType = LoopType.Yoyo;

    public PathType pathType;
    public PathMode pathMode;
    public Ease ease;
    public Vector3[] path;

    [SerializeField] private bool endless;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Waitsequance());
    }
    void Movement()
    {
        Sequence move = DOTween.Sequence();

        move.SetDelay(loopDelay);
        if (!endless)
        {
            move.Append(transform.DOPath(path, moveduration, pathType, pathMode, 10).SetEase(ease));
        }
        if (endless)
        {
            move.Append(transform.DOLocalPath(path, moveduration, pathType, pathMode, 10).SetEase(ease));
        }
        move.AppendInterval(loopDelay);
        move.SetLoops(-1, loopType);
    }
    void Rotation()
    {
        Sequence rotate = DOTween.Sequence();

        rotate.SetDelay(rotDelay);
        rotate.Append(transform.DORotate(new Vector3(0, 0, rotationAmount), rotduration, RotateMode.FastBeyond360).SetEase(ease));
        rotate.AppendInterval(rotDelay);
        rotate.SetLoops(-1, LoopType.Incremental);
    }
    private IEnumerator Waitsequance()
    {
        yield return new WaitForSeconds(startdelay);
        Movement();
        Rotation();
    }
}
