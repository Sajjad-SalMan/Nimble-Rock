using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class ReviveUI : MonoBehaviour
{
    public static ReviveUI instance;

    private bool revived1;
    private bool reviveMax;

    public GameObject reviveScreen;
    public GameObject levelCompletePanal;
    public GameObject blackPanal;

    public RevivePosition revivePosition;

    [SerializeField] private TMP_Text countDownText;

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

        LevelComplete.LevelEnded = false;
    }
    private void Start()
    {
        reviveScreen.SetActive(false);
    }
    public void YouwanttoRevive()
    {
        //All revive done
        if (reviveMax && !revived1)
        {
            StartCoroutine(GameOver());
        }

//Second Revive
        if (revived1)
        {
            reviveMax = true;
            reviveScreen.SetActive(true);
            revived1 = false;
            StartCoroutine(CountDown());
        }

//First Revive
        if (!revived1 && !reviveMax)         
        {
            revived1 = true;
            reviveScreen.SetActive(true);
            StartCoroutine(CountDown());
        }
        AdsInitializer.instance.InitializeAds();
    }

    IEnumerator GameOver()
    {
        reviveScreen.SetActive(false);
        blackPanal.GetComponent<CanvasGroup>().DOFade(1f, 1.5f);
        yield return new WaitForSeconds(2f);
        levelCompletePanal.SetActive(true);
    }
    public void ReviveDone()
    {
        reviveScreen.SetActive(false);
        revivePosition.SetPos();
    }
    
    public void NoThanks()
    {
        StartCoroutine(GameOver());

        LevelComplete.LevelEnded = true;
    }

    private IEnumerator CountDown()
    {
        yield return new WaitForSecondsRealtime(1);
        countDownText.SetText("2");
        yield return new WaitForSecondsRealtime(1);
        countDownText.SetText("1");
        yield return new WaitForSecondsRealtime(1);
        if (!RewardedAdsButton.reviving)
        {
            NoThanks();
        }
        else
        {
            countDownText.SetText("3");
            RewardedAdsButton.reviving = false;
        }
    }
}
