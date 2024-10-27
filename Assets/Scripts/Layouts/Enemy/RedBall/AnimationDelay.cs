using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDelay : MonoBehaviour
{
    public Animator animator;
    public float startDelay;
    public float speed = 1;

    [Header("Reset")]

    [SerializeField] private bool hasResetAnim;
    public float resetTimer;
    public float movingDelayEqualizer;

    private void Start()
    {
        StartCoroutine(Delaytime());
        animator.speed = speed;
        StartCoroutine(Replay());
    }
    IEnumerator Delaytime()
    {
        animator.enabled = false;
        yield return new WaitForSeconds(startDelay);
        animator.enabled = true;
    }
    IEnumerator Replay()
    {
        yield return new WaitForSeconds(movingDelayEqualizer);

        if (hasResetAnim)
        {
            while (true)
            {
                yield return new WaitForSeconds(resetTimer);
                animator.Play("Bounce", -1, 0);
            }
        }
    }
}
