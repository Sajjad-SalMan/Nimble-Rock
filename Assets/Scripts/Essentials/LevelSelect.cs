using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button[] LevelButtons;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("LevelReached", 1);

        for (int i = 0; i < LevelButtons.Length; i++)
        {
            if (i + 1  > levelReached)

                LevelButtons[i].interactable = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
