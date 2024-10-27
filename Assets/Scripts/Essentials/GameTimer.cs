using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public static bool timerActive;
    float time;
    public TMP_Text finalText;
    public TMP_Text IGUITextSec;
    public TMP_Text bestTime;
    public TMP_Text showTimeinResume;
    void Start()
    {
        time = 0;

        bestTime.text = PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name).ToString("0.0");
        timerActive = false;
    }
     
    void Update()
    {
        StartTimer();
        
        if (timerActive)
        {
            time = time + Time.deltaTime;
        }
        finalText.text = time.ToString("0.0");
        IGUITextSec.text = time.ToString("0.0");
        showTimeinResume.text = time.ToString("0.0");
        StopTimer();
        SetHighestScore();
    }

    void StartTimer()
    {
        if (!PlayerController.startPhase && !LevelComplete.LevelEnded)
        {
            timerActive = true;
            if (Collectable.stopTime)
            {
                timerActive = false;
            }
        }
    }
    void StopTimer()
    {
        if (LevelComplete.LevelEnded && !PlayerController.startPhase)
        {
            timerActive = false;
        }
    }
    void SetHighestScore()
    {

        if (LevelComplete.LevelEnded && !PlayerController.startPhase && SceneManager.GetActiveScene().buildIndex != 21)
        {
            if(time < PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name, 999))
            {
                PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name, time);
                bestTime.text = time.ToString("0.0");
            }
        }
    }
}
