﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_gate : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.Play("spike gate");
        }
    }
}
