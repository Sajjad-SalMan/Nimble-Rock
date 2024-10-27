using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSO : MonoBehaviour
{
    public ParticleSystem left_dashEffect;
    public ParticleSystem right_dashEffect;
    public ParticleSystem left_jumpEffect;
    public ParticleSystem right_jumpEffect;

    private PlayerController player;
    private SpriteRenderer[] sprite;
    private BoxCollider2D[] col;

    public float backforce;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        sprite = GetComponentsInChildren<SpriteRenderer>();
        col = GetComponentsInChildren<BoxCollider2D>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")                      //Destroyable-Object Jump
        {
            if (player.grounded == false)
            {
                player.rb.AddForce(new Vector2(player.jumpforce / backforce, 0), ForceMode2D.Impulse);
                StartCoroutine(JumpBreak());
                AudioManager.instance.Play("Brick");
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)           //Destroyable-Object Dash
    {
        if (collision.gameObject.tag == "Player")
        {
            if (player.isdashing)
            {
                StartCoroutine(DashBreak());
                var CM = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera_Shake>();
                CM.CamShake();
                AudioManager.instance.Play("Brick");
            }
        }
    }

    private IEnumerator DashBreak()
    {
        if(player.jumpforce > 0)
        {
            left_dashEffect.Play();
        }
        else
        {
            right_dashEffect.Play();
        }
        foreach (var s in sprite)
        {
            s.enabled = false;
        }
        foreach (var c in col)
        {
            c.enabled = false;
        }

        yield return new WaitForSeconds(2f);
        foreach (var s in sprite)
        {
            s.enabled = true;
        }
        foreach (var c in col)
        {
            c.enabled = true;
        }
        
    }
    private IEnumerator JumpBreak()
    {
        if (player.jumpforce > 0)
        {
            right_jumpEffect.Play();
        }
        if (player.jumpforce < 0)
        {
            left_jumpEffect.Play();
        }
        foreach (var s in sprite)
        {
            s.enabled = false;
        }
        foreach (var c in col)
        {
            c.enabled = false;
        }

        yield return new WaitForSeconds(2f);
        foreach (var s in sprite)
        {
            s.enabled = true;
        }
        foreach (var c in col)
        {
            c.enabled = true;
        }
    }
}
