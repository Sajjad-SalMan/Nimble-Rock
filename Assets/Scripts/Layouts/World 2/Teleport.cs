using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    private PlayerController playerController;
    public Transform out_position;

    public float force;
    public bool same_lane;

    private bool tp;

    private void Start()
    {
        playerController = player.GetComponent<PlayerController>();
    }

    private void FixedUpdate()
    {
        if(tp && same_lane)
        {
            StartCoroutine(Same_lane_sequance());
        }
        if(tp && !same_lane)
        {
            StartCoroutine(Oposite_lane_sequance());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tp = true;
            AudioManager.instance.Play("TP");
        }
    }

    IEnumerator Oposite_lane_sequance()
    {
        tp = false;
        playerController.jumpforce *= -1;
        playerController.rb.gravityScale *= -1;
        playerController.speed = 0;
        player.GetComponentInChildren<TrailRenderer>().emitting = false;
        yield return new WaitForSeconds(0.05f);

        player.transform.position = out_position.position;

        yield return new WaitForSeconds(0.15f);

        playerController.rb.AddForce(new Vector2(force, 0), ForceMode2D.Impulse);
        player.GetComponentInChildren<TrailRenderer>().emitting = true;
        playerController.speed = 4;
    }
    IEnumerator Same_lane_sequance()
    {
        tp = false;
        playerController.speed = 0;
        player.GetComponentInChildren<TrailRenderer>().emitting = false;
        yield return new WaitForSeconds(0.05f);

        player.transform.position = out_position.position;

        yield return new WaitForSeconds(0.15f);

        player.GetComponentInChildren<TrailRenderer>().emitting = true;
        playerController.rb.AddForce(new Vector2(force, 0), ForceMode2D.Impulse);
        playerController.speed = 4;
    }
}
