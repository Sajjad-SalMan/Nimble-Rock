using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D rb;
    private LayerMask ground;
    private float aspectRatio = Screen.width / 2;

    //Control
    private int defaultCtrl;
    [HideInInspector] public bool JumpCtrl;
    [HideInInspector] public bool dashCtrl;
    //movement
    public float speed;
    public static bool startPhase;
    [HideInInspector] public bool do_once;

    [Header("Jump")]                    //JUMP
    public float jumpforce;
    [SerializeField] private int gravity = 4;
    [HideInInspector] public bool grounded;
    [HideInInspector] public Transform groundcheck;
    [HideInInspector] public bool canjump;
    [HideInInspector] public bool jumpSoundPlaying = true;

    [Header("Dash")]                    //DASH
    public float dashspeed;
    public float dashtime;
    private float remainingtime;
    [HideInInspector] public bool isdashing;
    private bool dashSoundPlaying = true;

    public float cooldown;
    [HideInInspector]
    public float cooldownTimer;

    private Coroutine c;    //for stopping coroutine
    private ParticleSystem dasheffect;
    public ParticleSystem jumpeffect;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        ground = LayerMask.GetMask("Ground");
        dasheffect = GetComponentInChildren<ParticleSystem>();
    }
    public void Start()
    {
        Inactive();
        do_once = false;

        defaultCtrl = PlayerPrefs.GetInt("Inverted");
    }

    void Update()
    {
        grounded = Physics2D.OverlapCircle(groundcheck.position, .2f, ground);

        if (grounded == true)
        {
            startPhase = false;
        }

        if (cooldownTimer > 0)              //Dash cool-down
        {
            cooldownTimer -= Time.deltaTime;
        }


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < aspectRatio && startPhase && !isMouseOverUI())
                {
                    if (!do_once)
                    {
                        rb.gravityScale = gravity;
                        EndStartPhase();
                        do_once = true;
                    }
                }
                if (touch.position.x > aspectRatio && startPhase && !isMouseOverUI())
                {
                    if (!do_once)
                    {
                        rb.gravityScale = -gravity;
                        EndStartPhase();
                        do_once = true;
                    }
                }

                //Defualt-Inverted Control
                if (defaultCtrl == 0)
                {
                    JumpCtrl = touch.position.x > aspectRatio;
                    dashCtrl = touch.position.x < aspectRatio;
                }
                else
                {
                    JumpCtrl = touch.position.x < aspectRatio;
                    dashCtrl = touch.position.x > aspectRatio;
                }

                //jump
                if (JumpCtrl && grounded == true && !startPhase && !isMouseOverUI() && !LevelComplete.LevelEnded)
                {
                    canjump = true;
                    jumpSoundPlaying = false;
                }

                //Dash
                if (dashCtrl && cooldownTimer <= 0 && !startPhase && !isMouseOverUI() && !LevelComplete.LevelEnded)
                {
                    isdashing = true;
                    cooldownTimer = cooldown;
                }
            }
        }

        Endgame();
        JumpSoundandVibration();
        DashSoundandVibration();
    }
    void FixedUpdate()
    {
        movement();
        dash();
        jump();
    }

    public bool isMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject(0);
    }

    public void Inactive()
    {
        startPhase = true;
        rb.gravityScale = 0;
        speed = 0;
    }

    private void EndStartPhase()
    {
        if (rb.gravityScale > 0)
        {
            speed = 4;
        }
        if (rb.gravityScale < 0)
        {
            speed = 4;
            jumpforce *= -1;
        }
    }
    void movement()
    {
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }

    public void jump()
    {
        if (canjump)
        {
            rb.AddForce(new Vector2(jumpforce, 0), ForceMode2D.Impulse);
            canjump = false;
            rb.gravityScale *= -1;
            jumpforce *= -1;
            jumpeffect.Play();
            
        }
    }

    void JumpSoundandVibration()
    {
        if (canjump)
        {
            if (jumpSoundPlaying == false)
            {
                AudioManager.instance.Play("Jump");
                jumpSoundPlaying = true;
                Vibrator.Vibrate(40);
            }
        }
    }

    //DASH
    void dash()
    {

        if (isdashing)
        {
            rb.velocity = Vector2.up * dashspeed;
            remainingtime -= Time.deltaTime;
            dasheffect.Play();
        }
        if (remainingtime <= 0)
        {
            isdashing = false;
            remainingtime = dashtime;
            dashSoundPlaying = false;
        }
    }
    void DashSoundandVibration()
    {
        if (isdashing)
        {
            if (dashSoundPlaying == false)
            {
                AudioManager.instance.Play("Dash");
                dashSoundPlaying = true;
                Vibrator.Vibrate(40);
            }
        }

    }
    void Endgame()
    {
        if (LevelComplete.LevelEnded && grounded)
        {
            rb.gravityScale = 0;
        }
    }
}
