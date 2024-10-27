using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweaker : MonoBehaviour
{
    private GameObject player;
    private PlayerController controller;

    [SerializeField] private float speed;
    [SerializeField] private float jump;
    [SerializeField] private float dash;
    [SerializeField] private float gravity = 1;

    private float original_speed;
    private float original_dash;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        controller = player.GetComponent<PlayerController>();

        original_dash = controller.dashspeed;
        original_speed = 4;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            controller.speed = speed;
            controller.jumpforce *= jump;
            controller.dashspeed = dash;
            controller.rb.gravityScale *= gravity;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            controller.speed = original_speed;
            controller.jumpforce /= jump;
            controller.dashspeed = original_dash;
            controller.rb.gravityScale /= gravity;
        }
    }
}
