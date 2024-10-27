using System.Collections;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;

public class ResumeUI : MonoBehaviour
{
    public GameObject player;
    private Collectable collectable;

    public RectTransform buttons;

    public GameObject resumePanal;
    public GameObject InGameUI;
    public GameObject levelCompletePanal;
    public GameObject blackPanal;

    public TMP_Text collectedCoinText;
    public TMP_Text targetCoinText;
    public TMP_Text currentLevelText;
    private void Start()
    {
        levelCompletePanal.SetActive(false);
        collectable = player.GetComponent<Collectable>();
    }
    private void Update()
    {
        if (LevelComplete.LevelEnded == true)
        {
            StartCoroutine(LevelCompAnim());
        }

        collectedCoinText.SetText(collectable.coin_amount.ToString());
        targetCoinText.SetText(collectable.required_coin.ToString());
    }
    public void PauseAnimation()
    {
        InGameUI.SetActive(false);
        resumePanal.SetActive(true);
        buttons.DOScale(0.4f, .2f ).SetUpdate(true);
        buttons.DOAnchorPos(Vector2.zero, .2f).SetUpdate(true);
    }
    public void Resume()
    {
        Invoke("ClosePauseMenu", .2f);
        buttons.DOScale(.02f, .2f);
        buttons.DOAnchorPos(new Vector2(90, 250), .2f);
    }
    public void ClosePauseMenu()
    {
        InGameUI.SetActive(true);
        resumePanal.SetActive(false);
    }

    IEnumerator LevelCompAnim()
    {
        blackPanal.GetComponent<CanvasGroup>().DOFade(1f, 1.5f);
        currentLevelText.SetText(SceneManager.GetActiveScene().name);
        yield return new WaitForSeconds(2f);
        levelCompletePanal.SetActive(true);
    }
}
