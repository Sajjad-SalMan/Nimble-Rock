using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One_Way : MonoBehaviour
{
    private PlayerController playerController;

    public float force;
    [SerializeField] private bool rightWay;

    private void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (rightWay)
            {
                RightWay();
            }
            else
            {
                LeftWay();
            }
            AudioManager.instance.Play("One way");
        }
    }

    void RightWay()
    {
        playerController.rb.gravityScale = -1 * Mathf.Abs(playerController.rb.gravityScale);
        playerController.jumpforce = -1 * Mathf.Abs(playerController.jumpforce);
        playerController.rb.AddForce(new Vector2(force, 0));
    }
    void LeftWay()
    {
        playerController.rb.gravityScale = Mathf.Abs(playerController.rb.gravityScale);
        playerController.jumpforce = Mathf.Abs(playerController.jumpforce);
        playerController.rb.AddForce(new Vector2(force * -1, 0));
    }
}
