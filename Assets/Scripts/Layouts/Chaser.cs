using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Chaser : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    public Respawn respawn;
    private float deathcount;
    private Vector3 lastCheckPoint;
    private Vector3 pos;
    public float offset;
    public float smoothTansitionTime;
    [SerializeField] private bool chaser1;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //deathcount = Respawn.died;

    }
    private void Update()
    {
        pos = lastCheckPoint - new Vector3(0, offset, 0);
        if (!PlayerController.startPhase)
        {
            rb.velocity = new Vector2(0, speed);
        }
        StartCoroutine(ResetPos());
    }

    private IEnumerator ResetPos()
    {
        if (deathcount < Respawn.died)
        {
            deathcount = Respawn.died;
            if (!chaser1)
            {
                yield return new WaitForSeconds(smoothTansitionTime);
                transform.DOMove(pos, .15f);
            }
            else
            {
                yield return new WaitForSeconds(smoothTansitionTime);
                transform.position = pos;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CheckPoint")
        {
            lastCheckPoint = collision.gameObject.transform.position;
        }
    }
}
