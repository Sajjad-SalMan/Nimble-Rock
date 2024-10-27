using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private PlayerController player;

    private bool isfrozen;
    public GameObject hitEffect;

    //For destorying instantiation;
    private GameObject Hit;

    void Start()
    {
        player = GetComponent<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var Jump_Hit_Left = new Vector3(-0.2f, 0f, 0f);
        var Jump_Hit_Right = new Vector3(0.2f, 0f, 0f);

        var Impact_offset = new Vector3(0f, 0.1f, 0f);

        if (collision.gameObject.tag == "Enemy")
        {
            if (player.isdashing)
            {
                Hit = Instantiate(hitEffect, collision.transform.position , Quaternion.identity);
                stop(.1f);
                collision.gameObject.GetComponent<CircleCollider2D>().enabled = false;
                collision.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
                Destroy(collision.gameObject, .15f);
                AudioManager.instance.Play("Enemy Death");
            }
            if(!player.grounded)
            {
                if(player.jumpforce > 0)
                {
                    Hit = Instantiate(hitEffect, collision.transform.position + Jump_Hit_Left, Quaternion.Euler (0f, 0f, 90f));
                }
                if (player.jumpforce < 0)
                {
                    Hit = Instantiate(hitEffect, collision.transform.position + Jump_Hit_Right, Quaternion.Euler(0f, 0f, -90f));
                }
                stop(.1f);
                collision.gameObject.GetComponent<CircleCollider2D>().enabled = false;
                collision.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
                Destroy(collision.gameObject, .15f);
                AudioManager.instance.Play("Enemy Death");
            }
        }
    }

    //delay on hit system
    private void stop(float duration)
    {
        if (isfrozen)
            return;
        Time.timeScale = 0;
        StartCoroutine(delayonhit(duration));
        Destroy(Hit, .2f);
    }

    private IEnumerator delayonhit(float duration)
    {
        isfrozen = true;
        yield return new WaitForSecondsRealtime(duration); 
        Time.timeScale = 1f;
        isfrozen = false;
    }
}
