using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndlessScore : MonoBehaviour
{
    private bool timerActive;
    float score;
    public TMP_Text finalText;
    public TMP_Text IGUITextSec;
    public TMP_Text bestScore;

    private GameObject player;
    private Rigidbody2D rb;
    private PlayerController playerController;

    void Start()
    {
        score = 0;

        bestScore.text = PlayerPrefs.GetFloat("Endless_Score").ToString("0");

        player = GameObject.FindGameObjectWithTag("Player");
        rb = player.GetComponent<Rigidbody2D>();
        playerController = player.GetComponent<PlayerController>();
    }

    void Update()
    {
        StartTimer();
        EndlessTimerSystem();
        StopTimer();
        SetHighestScore();

        if (SoftLockTrigger.finishLine)
        {
            if (score > PlayerPrefs.GetFloat("Endless_Score", 0))
            {
                PlayerPrefs.SetFloat("Endless_Score", score);
                bestScore.text = score.ToString("0");
            }
        }
    }

    void StartTimer()
    {
        if (!PlayerController.startPhase && !LevelComplete.LevelEnded && !SoftLockTrigger.finishLine)
        {
            timerActive = true;
        }
    }
    void StopTimer()
    {
        if (LevelComplete.LevelEnded && !PlayerController.startPhase || SoftLockTrigger.finishLine)
        {
            timerActive = false;
        }
    }
    void SetHighestScore()
    {

        if (LevelComplete.LevelEnded && !PlayerController.startPhase && SceneManager.GetActiveScene().buildIndex == 21)
        {
            if (score > PlayerPrefs.GetFloat("Endless_Score", 0))
            {
                PlayerPrefs.SetFloat("Endless_Score", score);
                bestScore.text = score.ToString("0");
            }
        }
    }

    //pause score for Endless Level
    void EndlessTimerSystem()
    {
        if (rb.velocity.y > 1 && timerActive && Time.timeScale != 0 && playerController.enabled)
        {
            score += rb.velocity.y * 0.01f;
        }

        IGUITextSec.text = score.ToString("0");
        finalText.text = score.ToString("0");
    }
}
