using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject levels;

    [Header("Level Select")]
    public RectTransform world1;
    public RectTransform world2;
    public GameObject[] particles;
    public Button[] leftRIght;

    [Header("Options Menu")]
    public RectTransform options;
    public RectTransform menuCanvas;
    public GameObject menusetUp, menusetDown;

    [SerializeField]
    private GameObject quitConfirmation;

    private void Start()
    {
        if (StartButton.levelsButton)
        {
            GotoLevels();
        }
        else
        {
            mainMenu.SetActive(true);
            levels.SetActive(false);
            particles[0].SetActive(true);
            particles[1].SetActive(false);
        }

    }

    public void startbutton()
    {
        if(PlayerPrefs.GetInt("TutorialIsDone", 0) == 0)
        {
            return;
        }
        else
        {
            mainMenu.SetActive(false);
            levels.SetActive(true);
            leftRIght[1].interactable = true;
            leftRIght[0].interactable = false;
            ClickSFX();
        }
    }
    public void HomeButton()
    {
        mainMenu.SetActive(true);
        levels.SetActive(false);
        WorldOneButton();

        ClickSFX();
    }
    public void QuitGame()
    {
        quitConfirmation.SetActive(true);
        quitConfirmation.transform.DOScale(1, .2f).SetEase(Ease.OutBounce);
    }
    public void YesQuit()
    {
        Application.Quit();
    }
    public void NoCancelQuit()
    {
        quitConfirmation.SetActive(false);
        quitConfirmation.transform.DOScale(.8f, .1f);
    }
    public void WorldTwoButton()
    {
        world1.DOAnchorPosX(-1000, .25f);
        world2.DOAnchorPos(Vector2.zero, .25f);
        particles[0].SetActive(false);
        particles[1].SetActive(true);
        leftRIght[1].interactable = false;
        leftRIght[0].interactable = true;

        ClickSFX();
    }
    public void WorldOneButton()
    {
        world2.DOAnchorPosX(1000, .25f);
        world1.DOAnchorPos(Vector2.zero, .25f);
        particles[0].SetActive(true);
        particles[1].SetActive(false);
        leftRIght[1].interactable = true;
        leftRIght[0].interactable = false;

        ClickSFX();
    }

    public void ClickSFX()
    {
        AudioManager.instance.Play("Click");
    }

    public void Options()
    {
        menusetDown.transform.DOLocalMoveY(-2.5f, .25f);
        menusetUp.transform.DOLocalMoveY(2.5f, .25f);
        menuCanvas.DOAnchorPosX(1000, .25f);
        options.DOAnchorPosX(0, .25f);

        ClickSFX();
    }
    public void BackfromOptions()
    {
        menusetDown.transform.DOLocalMoveY(0, .25f);
        menusetUp.transform.DOLocalMoveY(0f, .25f);
        menuCanvas.DOAnchorPosX(0, .25f);
        options.DOAnchorPosX(-1000, .25f);

        ClickSFX();
    }
    private void GotoLevels()
    {
        mainMenu.SetActive(false);
        levels.SetActive(true);
        leftRIght[1].interactable = true;
        leftRIght[0].interactable = false;

        StartButton.levelsButton = false;
    }
}
