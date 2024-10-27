using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public async void LoadScene(int sceneBuildIndex)
    {
        var scene = SceneManager.LoadSceneAsync(sceneBuildIndex);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Endless()
    {
        SceneManager.LoadSceneAsync(21);
    }

    public void Home()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void Tutorial()
    {
        if(PlayerPrefs.GetInt("TutorialIsDone", 0 ) == 0)
        {
            SceneManager.LoadSceneAsync(22);
            PlayerPrefs.SetInt("TutorialIsDone", 1);
        }
        else
        {
            return;
        }
    }
}
