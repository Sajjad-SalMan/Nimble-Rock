using System.Collections;
using UnityEngine;
using DG.Tweening;
public class EnemyTwo : MonoBehaviour
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

    public GameObject player;
    private PlayerController playerController;
    public GameObject effect;

    [SerializeField] private bool EndlessMode = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Waitsequance());
        playerController = player.GetComponent<PlayerController>();
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
        Sequence rotate = DOTween.Sequence();

        rotate.SetDelay(delay);
        rotate.Append(transform.DORotate(new Vector3(0, 0, 360), rotduration, RotateMode.FastBeyond360).SetEase(ease));
        rotate.AppendInterval(delay);
        rotate.SetLoops(-1, LoopType.Restart);
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (playerController.isdashing || playerController.grounded)
            {
                if(GetComponent<CircleCollider2D>() != null)
                {
                    GetComponent<CircleCollider2D>().enabled = false;
                }
                StartCoroutine(LightFlah());
            }
        }
    }
    IEnumerator LightFlah()
    {
        var rightJump = new Vector3(0.4f, 0, 0);
        var leftJump = new Vector3(-0.4f, 0, 0);

        GetComponentInChildren<SpriteRenderer>().enabled = false;
        yield return new WaitForSecondsRealtime(.1f);
        if (playerController.jumpforce < 0 && playerController.grounded)
        {
            Instantiate(effect, transform.position, Quaternion.Euler(0f, 0f, 90f));
        }
        if (playerController.jumpforce > 0 && playerController.grounded)
        {
            Instantiate(effect, transform.position, Quaternion.Euler(0f, 0f, -90f));
        }
        //Jump rotation
        if (playerController.jumpforce > 0 && !playerController.grounded)
        {
            Instantiate(effect, transform.position + leftJump, Quaternion.Euler(0f, 0f, 90f));
        }
        if (playerController.jumpforce < 0 && !playerController.grounded)
        {
            Instantiate(effect, transform.position + rightJump, Quaternion.Euler(0f, 0f, -90f));
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