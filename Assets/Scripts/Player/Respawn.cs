using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class Respawn : MonoBehaviour
{
    private PlayerController player;
    public ParticleSystem deathEffect;
    public SpriteRenderer sprite;
    private TrailRenderer trail;

    public Animator animator;

    private bool doOnceDeathOnTrigger;
    [HideInInspector] public static int died;
    private void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 21)
        {
            gameObject.GetComponent<Collectable>().enabled = false;
        }
    }
    private void Start()
    {
        player = GetComponent<PlayerController>();
        trail = GetComponentInChildren<TrailRenderer>();

        died = 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (player.isdashing == false && player.grounded)
            {
                if (died < 2)
                {
                    StartCoroutine(ReviveTwice());
                    DeathSoundandHaptic();
                }
                else
                {
                    died++;
                    StartCoroutine(DeathAnimation());
                    var CM = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera_Shake>();
                    CM.DeathShake();
                    DeathSoundandHaptic();
                }
            }
        }
        if (other.gameObject.tag == "Spike")
        {
            if (died < 2)
            {
                StartCoroutine(ReviveTwice());
                DeathSoundandHaptic();
            }
            else
            {
                died++;
                StartCoroutine(DeathAnimation());
                var CM = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera_Shake>();
                CM.DeathShake();
                DeathSoundandHaptic();
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chaser")
        {
            if (died < 2)
            {
                StartCoroutine(ReviveTwice());
                DeathSoundandHaptic();
            }
            else
            {
                died++;
                StartCoroutine(DeathAnimation());
                var CM = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera_Shake>();
                CM.DeathShake();
                DeathSoundandHaptic();
            }
        }
        if (collision.gameObject.tag == "Boundary")
        {
            
                if (died < 2)
                {
                    StartCoroutine(ReviveTwice());
                    DeathSoundandHaptic();
                }
                else
                {
                    if (!doOnceDeathOnTrigger)
                        {
                            died++;
                            StartCoroutine(DeathAnimationOnBoundary());
                            var CM = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera_Shake>();
                            CM.DeathShake();
                            DeathSoundandHaptic();
                            doOnceDeathOnTrigger = true;
                        }
                }
        }
    }

    private IEnumerator DeathAnimation()
    {
        player.enabled = false;
        GetComponent<Rigidbody2D>().simulated = false;
        sprite.enabled = false;
        trail.emitting = false;

        deathEffect.Play();

        if (SceneManager.GetActiveScene().buildIndex != 21)
        {
            yield return new WaitForSeconds(.3f);
            animator.SetTrigger("Start");
            yield return new WaitForSeconds(.5f);
            GameManager.instance.Restart();
        }
        else
        {
            if (AdsInitializer.adIsReady)
            {
                ReviveUI.instance.Invoke("YouwanttoRevive", .5f);
            }
            else
            {
                ReviveUI.instance.NoThanks();
            }
        }
    }

    private IEnumerator DeathAnimationOnBoundary()
    {
        player.enabled = false;
        if (GetComponent<Rigidbody2D>().gravityScale > 0)
        {
            transform.DOMoveX(transform.position.x + 1, 0.5f);
        }
        if (GetComponent<Rigidbody2D>().gravityScale < 0)
        {
            transform.DOMoveX(transform.position.x - 1, 0.5f);
        }
        yield return new WaitForSeconds(0.4f);
        player.rb.simulated = false;
        sprite.enabled = false;
        trail.emitting = false;
        deathEffect.Play();

        if (SceneManager.GetActiveScene().buildIndex != 21)
        {
            animator.SetTrigger("Start");
            yield return new WaitForSeconds(.5f);
            GameManager.instance.Restart();
        }
        else
        {
            if (AdsInitializer.adIsReady)
            {
                ReviveUI.instance.Invoke("YouwanttoRevive", .5f);
            }
            else
            {
                ReviveUI.instance.NoThanks();
            }
        }
    }

    private void DeathSoundandHaptic()
    {
        AudioManager.instance.Play("Death");
        Vibrator.Vibrate(80);
    }

    #region Revive Mechanics

    private IEnumerator ReviveTwice()
    {
        died +=1 ;
        player.enabled = false;
        player.rb.velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().simulated = false;
        sprite.enabled = false;
        trail.emitting = false;

        deathEffect.Play();
        yield return new WaitForSeconds(.5f);
        this.gameObject.GetComponent<RevivePosition>().SetPos();
        
    }

    #endregion
}
