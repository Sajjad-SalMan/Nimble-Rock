using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public static bool LevelEnded;
    private ParticleSystem[] particleSystems;

    private int nextSceneToLoad;

    private void Awake()
    {
        LevelEnded = false;
    }
    private void Start()
    {
        particleSystems = GetComponentsInChildren<ParticleSystem>();

        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            foreach(var i in particleSystems)
            {
                i.Play();
            }

            LevelEnded = true;
            var CM = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera_Shake>();
            CM.CamShake();

            AudioManager.instance.Play("Finish Line");
        }
        if(nextSceneToLoad > PlayerPrefs.GetInt("LevelReached"))
        {
                PlayerPrefs.SetInt("LevelReached", nextSceneToLoad);
        }

        //Rate this Game

        if (collision.tag == "Player")
        {

            if (2 == PlayerPrefs.GetInt("LevelReached") && PlayerPrefs.GetInt("FirstRateUS", 0) == 0)
            {
                EventManager.instance.ShowRateBox();
                PlayerPrefs.SetInt("FirstRateUS", 1);
            }
            if (8 == PlayerPrefs.GetInt("LevelReached") && PlayerPrefs.GetInt("SecondRateUS", 0) == 0)
            {
                EventManager.instance.ShowRateBox();
                PlayerPrefs.SetInt("SecondRateUS", 1);
            }
            if (14 == PlayerPrefs.GetInt("LevelReached") && PlayerPrefs.GetInt("ThirdRateUS", 0) == 0)
            {
                EventManager.instance.ShowRateBox();
                PlayerPrefs.SetInt("ThirdRateUS", 1);
            }
            if (20 == PlayerPrefs.GetInt("LevelReached") && PlayerPrefs.GetInt("ThirdRateUS", 0) == 0)
            {
                EventManager.instance.ShowRateBox();
                PlayerPrefs.SetInt("ThirdRateUS", 1);
            }
        }
    }
}