using UnityEngine;
using System;
using DG.Tweening;

public class StartButton : MonoBehaviour
{
    public GameObject locked;

    public static bool levelsButton;

    public void ChangeScene(int sceneBuildIndex)
    {
        GameManager.instance.LoadScene(sceneBuildIndex);

        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        AudioManager.instance.Play("Click");
    }

    public void NextLevel()
    {
        GameManager.instance.NextLevel();
        AudioManager.instance.Play("Click");
    }
    public void Replay()
    {
        GameManager.instance.Restart();
        AudioManager.instance.Play("Click");
    }

    public void Endless()
    {
        if (PlayerPrefs.GetInt("LevelReached") > 5)
        {
            GameManager.instance.Endless();
        }
        if (PlayerPrefs.GetInt("LevelReached") <= 5)
        {
            locked.SetActive(true);
            locked.transform.DOScale(1, .2f).SetEase(Ease.OutBounce);
        }

        AudioManager.instance.Play("Click");
    }

    public void ExitEndlessMsg()
    {
        locked.SetActive(false);
        locked.transform.DOScale(.8f, .1f);

        AudioManager.instance.Play("Click");
    }

    public void GotoLevels()
    {
        levelsButton = true;
    }
}
