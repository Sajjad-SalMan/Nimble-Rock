using TMPro;
using UnityEngine;

[System.Serializable]
public class LevelMask
{
    public GameObject canvas;
    public GameObject mask;
    public GameObject Img;
    public RectTransform levelImg;
    public TMP_Text highestScore;
    public string description;
    public TMP_Text levelDescription;
    [HideInInspector]
    public CanvasGroup descriptionCanvas;


    public RectTransform exitButton;
    public RectTransform playButton;
    
}
