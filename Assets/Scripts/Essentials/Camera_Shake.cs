using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_Shake : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void CamShake()
    {
        animator.SetTrigger("Shake");
    }
    public void DashShake()
    {
        animator.SetTrigger("Dash");
    }
    public void DeathShake()
    {
        animator.SetTrigger("Death");
    }
}
