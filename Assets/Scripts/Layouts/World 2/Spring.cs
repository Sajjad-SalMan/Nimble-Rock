using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    private PlayerController playerController;

    public float horizontalForce;
    public float verticleForce;
    [SerializeField]private bool horizontalSpring;

    private float timeCount;
    [SerializeField] private float secondsToApplyForce;
    private bool addingForce = false;

    private Animator animator;

    private void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        animator = GetComponentInChildren<Animator>();
        if(transform.rotation.z == 0 || transform.rotation.z == 180)
        {
            horizontalSpring = true;
        }
        else
        {
            horizontalSpring = false;
        }
    }

    private void FixedUpdate()
    {
        if (!addingForce)
        {
            return;
        }
        timeCount += Time.deltaTime;

        if (timeCount < secondsToApplyForce)
        {
            playerController.rb.AddRelativeForce(new Vector2(0, -verticleForce));
        }
        else
        {
            timeCount = 0;
            addingForce = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && horizontalSpring && !playerController.grounded)
        {  
            playerController.rb.AddForce(new Vector2(horizontalForce *playerController.jumpforce * Time.deltaTime, 0), ForceMode2D.Impulse);
            StartCoroutine(animationTrigger());
            AudioManager.instance.Play("Spring");
        }
        if (collision.gameObject.tag == "Player" && !horizontalSpring)
        {
            if(playerController.jumpforce > 0)
            {
                 addingForce = true;
                 playerController.rb.AddRelativeForce(new Vector2(horizontalForce * 2, 0));
                 StartCoroutine(animationTrigger());
            }
            if (playerController.jumpforce < 0)
            {
                addingForce = true;
                playerController.rb.AddRelativeForce(new Vector2(horizontalForce * -2, 0));
                StartCoroutine(animationTrigger());
            }
            AudioManager.instance.Play("Spring");
        }
    }
    IEnumerator animationTrigger()
    {
        animator.SetBool("Trigger", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("Trigger", false);
    }
}
