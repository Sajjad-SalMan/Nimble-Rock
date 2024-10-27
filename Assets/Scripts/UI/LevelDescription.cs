using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using DG.Tweening;

public class LevelDescription : MonoBehaviour
{
    public LevelMask[] levels;


    private void Start()
    {
        #region Description Text
        levels[0].levelDescription.SetText(levels[0].description);
        levels[1].levelDescription.SetText(levels[1].description);
        levels[2].levelDescription.SetText(levels[2].description);
        levels[3].levelDescription.SetText(levels[3].description);
        levels[4].levelDescription.SetText(levels[4].description);
        levels[5].levelDescription.SetText(levels[5].description);
        levels[6].levelDescription.SetText(levels[6].description);
        levels[7].levelDescription.SetText(levels[7].description);
        levels[8].levelDescription.SetText(levels[8].description);
        levels[9].levelDescription.SetText(levels[9].description);
        levels[10].levelDescription.SetText(levels[10].description);
        levels[11].levelDescription.SetText(levels[11].description);
        levels[12].levelDescription.SetText(levels[12].description);
        levels[13].levelDescription.SetText(levels[13].description);
        levels[14].levelDescription.SetText(levels[14].description);
        levels[15].levelDescription.SetText(levels[15].description);
        levels[16].levelDescription.SetText(levels[16].description);
        levels[17].levelDescription.SetText(levels[17].description);
        levels[18].levelDescription.SetText(levels[18].description);
        levels[19].levelDescription.SetText(levels[19].description);
        #endregion

        #region highest Score Text
        if (PlayerPrefs.GetFloat("Level 1") > 0)
        {
            levels[0].highestScore.SetText(PlayerPrefs.GetFloat("Level 1").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 2") > 0)
        {
            levels[1].highestScore.SetText(PlayerPrefs.GetFloat("Level 2").ToString("0.0"));
        }
        if(PlayerPrefs.GetFloat("Level 3") > 0)
        {
            levels[2].highestScore.SetText(PlayerPrefs.GetFloat("Level 3").ToString("0.0"));
        }
        if(PlayerPrefs.GetFloat("Level 4") > 0)
        {
            levels[3].highestScore.SetText(PlayerPrefs.GetFloat("Level 4").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 5") > 0)
        {
            levels[4].highestScore.SetText(PlayerPrefs.GetFloat("Level 5").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 6") > 0)
        {
            levels[5].highestScore.SetText(PlayerPrefs.GetFloat("Level 6").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 7") > 0)
        {
            levels[6].highestScore.SetText(PlayerPrefs.GetFloat("Level 7").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 8") > 0)
        {
            levels[7].highestScore.SetText(PlayerPrefs.GetFloat("Level 8").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 9") > 0)
        {
            levels[8].highestScore.SetText(PlayerPrefs.GetFloat("Level 9").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 10") > 0)
        {
            levels[9].highestScore.SetText(PlayerPrefs.GetFloat("Level 10").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 11") > 0)
        {
            levels[10].highestScore.SetText(PlayerPrefs.GetFloat("Level 11").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 12") > 0)
        {
            levels[11].highestScore.SetText(PlayerPrefs.GetFloat("Level 12").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 13") > 0)
        {
            levels[12].highestScore.SetText(PlayerPrefs.GetFloat("Level 13").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 14") > 0)
        {
            levels[13].highestScore.SetText(PlayerPrefs.GetFloat("Level 14").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 15") > 0)
        {
            levels[14].highestScore.SetText(PlayerPrefs.GetFloat("Level 15").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 16") > 0)
        {
            levels[15].highestScore.SetText(PlayerPrefs.GetFloat("Level 16").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 17") > 0)
        {
            levels[16].highestScore.SetText(PlayerPrefs.GetFloat("Level 17").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 18") > 0)
        {
            levels[17].highestScore.SetText(PlayerPrefs.GetFloat("Level 18").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 19") > 0)
        {
            levels[18].highestScore.SetText(PlayerPrefs.GetFloat("Level 19").ToString("0.0"));
        }
        if (PlayerPrefs.GetFloat("Level 20") > 0)
        {
            levels[19].highestScore.SetText(PlayerPrefs.GetFloat("Level 20").ToString("0.0"));
        }

        #endregion

        #region Canvas Reference
        levels[0].descriptionCanvas = levels[0].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[1].descriptionCanvas = levels[1].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[2].descriptionCanvas = levels[2].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[3].descriptionCanvas = levels[3].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[4].descriptionCanvas = levels[4].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[5].descriptionCanvas = levels[5].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[6].descriptionCanvas = levels[6].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[7].descriptionCanvas = levels[7].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[8].descriptionCanvas = levels[8].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[9].descriptionCanvas = levels[9].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[10].descriptionCanvas = levels[10].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[11].descriptionCanvas = levels[11].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[12].descriptionCanvas = levels[12].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[13].descriptionCanvas = levels[13].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[14].descriptionCanvas = levels[14].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[15].descriptionCanvas = levels[15].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[16].descriptionCanvas = levels[16].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[17].descriptionCanvas = levels[17].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[18].descriptionCanvas = levels[18].levelDescription.gameObject.GetComponent<CanvasGroup>();
        levels[19].descriptionCanvas = levels[19].levelDescription.gameObject.GetComponent<CanvasGroup>();
        #endregion
    }
    #region Level 1
    public void Level1_onClick()
    {
        StartCoroutine(Level1());
    }
    public void Level1_exit()
    {
        StartCoroutine(RLevel1());
    }

    IEnumerator Level1()
    {
        levels[0].canvas.SetActive(true);
        levels[0].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[0].mask.transform.DOScale(12, .2f);
        levels[0].levelImg.DOAnchorPosX(0, .2f);
        levels[0].levelImg.DOAnchorPosY(450, .2f);
        levels[0].Img.transform.DOScale(1.5f, .2f);

        levels[0].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[0].descriptionCanvas.DOFade(1, .5f);
        levels[0].highestScore.rectTransform.DOAnchorPosY(0, .5f);

        yield return new WaitForSeconds(0.1f);
        levels[0].exitButton.DOAnchorPosX(-100, .1f);
        levels[0].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel1()
    {
        levels[0].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[0].mask.transform.DOScale(0.1f, .1f);
        levels[0].levelImg.DOAnchorPosX(-230, .1f);
        levels[0].levelImg.DOAnchorPosY(186, .1f);
        levels[0].Img.transform.DOScale(1.2f, .1f);
        levels[0].exitButton.DOAnchorPosX(-500, .1f);
        levels[0].playButton.DOAnchorPosX(500, .1f);


        levels[0].descriptionCanvas.DOFade(0, .1f);
        levels[0].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[0].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[0].canvas.SetActive(false);
    }

    #endregion

    #region Level 2
    public void Level2_onClick()
    {
        StartCoroutine(Level2());
    }
    public void Level2_exit()
    {
        StartCoroutine(RLevel2());
    }

    IEnumerator Level2()
    {
        levels[1].canvas.SetActive(true);
        levels[1].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[1].mask.transform.DOScale(12, .2f);
        levels[1].levelImg.DOAnchorPosX(8, .2f);
        levels[1].levelImg.DOAnchorPosY(450, .2f);
        levels[1].Img.transform.DOScale(1.5f, .2f);

        levels[1].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[1].descriptionCanvas.DOFade(1, .5f);
        levels[1].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[1].exitButton.DOAnchorPosX(-100, .1f);
        levels[1].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel2()
    {
        levels[1].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[1].mask.transform.DOScale(0.1f, .1f);
        levels[1].levelImg.DOAnchorPosX(8, .1f);
        levels[1].levelImg.DOAnchorPosY(185, .1f);
        levels[1].Img.transform.DOScale(1.2f, .1f);
        levels[1].exitButton.DOAnchorPosX(-500, .1f);
        levels[1].playButton.DOAnchorPosX(500, .1f);

        levels[1].descriptionCanvas.DOFade(0, .1f);
        levels[1].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[1].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[1].canvas.SetActive(false);
    }
    #endregion

    #region Level 3
    public void Level3_onClick()
    {
        StartCoroutine(Level3());
    }
    public void Level3_exit()
    {
        StartCoroutine(RLevel3());
    }

    IEnumerator Level3()
    {
        levels[2].canvas.SetActive(true);
        levels[2].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[2].mask.transform.DOScale(12, .2f);
        levels[2].levelImg.DOAnchorPosX(0, .2f);
        levels[2].levelImg.DOAnchorPosY(450, .2f);
        levels[2].Img.transform.DOScale(1.5f, .2f);

        levels[2].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[2].descriptionCanvas.DOFade(1, .5f);
        levels[2].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[2].exitButton.DOAnchorPosX(-100, .1f);
        levels[2].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel3()
    {
        levels[2].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[2].mask.transform.DOScale(0.1f, .1f);
        levels[2].levelImg.DOAnchorPosX(222, .1f);
        levels[2].levelImg.DOAnchorPosY(185, .1f);
        levels[2].Img.transform.DOScale(1.2f, .1f);
        levels[2].exitButton.DOAnchorPosX(-500, .1f);
        levels[2].playButton.DOAnchorPosX(500, .1f);

        levels[2].descriptionCanvas.DOFade(0, .1f);
        levels[2].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[2].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[2].canvas.SetActive(false);
    }
    #endregion

    #region Level 4
    public void Level4_onClick()
    {
        StartCoroutine(Level4());
    }
    public void Level4_exit()
    {
        StartCoroutine(RLevel4());
    }

    IEnumerator Level4()
    {
        levels[3].canvas.SetActive(true);
        levels[3].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[3].mask.transform.DOScale(12, .2f);
        levels[3].levelImg.DOAnchorPosX(0, .2f);
        levels[3].levelImg.DOAnchorPosY(450, .2f);
        levels[3].Img.transform.DOScale(1.5f, .2f);

        levels[3].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[3].descriptionCanvas.DOFade(1, .5f);
        levels[3].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[3].exitButton.DOAnchorPosX(-100, .1f);
        levels[3].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel4()
    {
        levels[3].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[3].mask.transform.DOScale(0.1f, .1f);
        levels[3].levelImg.DOAnchorPosX(-107, .1f);
        levels[3].levelImg.DOAnchorPosY(32, .1f);
        levels[3].Img.transform.DOScale(1.2f, .1f);
        levels[3].exitButton.DOAnchorPosX(-500, .1f);
        levels[3].playButton.DOAnchorPosX(500, .1f);

        levels[3].descriptionCanvas.DOFade(0, .1f);
        levels[3].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[3].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[3].canvas.SetActive(false);
    }
    #endregion

    #region Level 5
    public void Level5_onClick()
    {
        StartCoroutine(Level5());
    }
    public void Level5_exit()
    {
        StartCoroutine(RLevel5());
    }

    IEnumerator Level5()
    {
        levels[4].canvas.SetActive(true);
        levels[4].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[4].mask.transform.DOScale(12, .2f);
        levels[4].levelImg.DOAnchorPosX(0, .2f);
        levels[4].levelImg.DOAnchorPosY(450, .2f);
        levels[4].Img.transform.DOScale(1.5f, .2f);

        levels[4].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[4].descriptionCanvas.DOFade(1, .5f);
        levels[4].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[4].exitButton.DOAnchorPosX(-100, .1f);
        levels[4].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel5()
    {
        levels[4].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[4].mask.transform.DOScale(0.1f, .1f);
        levels[4].levelImg.DOAnchorPosX(123, .1f);
        levels[4].levelImg.DOAnchorPosY(32, .1f);
        levels[4].Img.transform.DOScale(1.2f, .1f);
        levels[4].exitButton.DOAnchorPosX(-500, .1f);
        levels[4].playButton.DOAnchorPosX(500, .1f);

        levels[4].descriptionCanvas.DOFade(0, .1f);
        levels[4].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[4].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[4].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 6
    public void Level6_onClick()
    {
        StartCoroutine(Level6());
    }
    public void Level6_exit()
    {
        StartCoroutine(RLevel6());
    }

    IEnumerator Level6()
    {
        levels[5].canvas.SetActive(true);
        levels[5].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[5].mask.transform.DOScale(12, .2f);
        levels[5].levelImg.DOAnchorPosX(0, .2f);
        levels[5].levelImg.DOAnchorPosY(450, .2f);
        levels[5].Img.transform.DOScale(1.5f, .2f);

        levels[5].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[5].descriptionCanvas.DOFade(1, .5f);
        levels[5].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[5].exitButton.DOAnchorPosX(-100, .1f);
        levels[5].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel6()
    {
        levels[5].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[5].mask.transform.DOScale(0.1f, .1f);
        levels[5].levelImg.DOAnchorPosX(-227, .1f);
        levels[5].levelImg.DOAnchorPosY(-122, .1f);
        levels[5].Img.transform.DOScale(1.2f, .1f);
        levels[5].exitButton.DOAnchorPosX(-500, .1f);
        levels[5].playButton.DOAnchorPosX(500, .1f);

        levels[5].descriptionCanvas.DOFade(0, .1f);
        levels[5].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[5].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[5].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 7
    public void Level7_onClick()
    {
        StartCoroutine(Level7());
    }
    public void Level7_exit()
    {
        StartCoroutine(RLevel7());
    }

    IEnumerator Level7()
    {
        levels[6].canvas.SetActive(true);
        levels[6].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[6].mask.transform.DOScale(12, .2f);
        levels[6].levelImg.DOAnchorPosX(0, .2f);
        levels[6].levelImg.DOAnchorPosY(450, .2f);
        levels[6].Img.transform.DOScale(1.5f, .2f);

        levels[6].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[6].descriptionCanvas.DOFade(1, .5f);
        levels[6].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[6].exitButton.DOAnchorPosX(-100, .1f);
        levels[6].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel7()
    {
        levels[6].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[6].mask.transform.DOScale(0.1f, .1f);
        levels[6].levelImg.DOAnchorPosX(8, .1f);
        levels[6].levelImg.DOAnchorPosY(-123, .1f);
        levels[6].Img.transform.DOScale(1.2f, .1f);
        levels[6].exitButton.DOAnchorPosX(-500, .1f);
        levels[6].playButton.DOAnchorPosX(500, .1f);

        levels[6].descriptionCanvas.DOFade(0, .1f);
        levels[6].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[6].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[6].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 8
    public void Level8_onClick()
    {
        StartCoroutine(Level8());
    }
    public void Level8_exit()
    {
        StartCoroutine(RLevel8());
    }

    IEnumerator Level8()
    {
        levels[7].canvas.SetActive(true);
        levels[7].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[7].mask.transform.DOScale(12, .2f);
        levels[7].levelImg.DOAnchorPosX(0, .2f);
        levels[7].levelImg.DOAnchorPosY(450, .2f);
        levels[7].Img.transform.DOScale(1.5f, .2f);

        levels[7].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[7].descriptionCanvas.DOFade(1, .5f);
        levels[7].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[7].exitButton.DOAnchorPosX(-100, .1f);
        levels[7].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel8()
    {
        levels[7].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[7].mask.transform.DOScale(0.1f, .1f);
        levels[7].levelImg.DOAnchorPosX(211, .1f);
        levels[7].levelImg.DOAnchorPosY(-122, .1f);
        levels[7].Img.transform.DOScale(1.2f, .1f);
        levels[7].exitButton.DOAnchorPosX(-500, .1f);
        levels[7].playButton.DOAnchorPosX(500, .1f);

        levels[7].descriptionCanvas.DOFade(0, .1f);
        levels[7].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[7].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[7].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 9
    public void Level9_onClick()
    {
        StartCoroutine(Level9());
    }
    public void Level9_exit()
    {
        StartCoroutine(RLevel9());
    }

    IEnumerator Level9()
    {
        levels[8].canvas.SetActive(true);
        levels[8].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[8].mask.transform.DOScale(12, .2f);
        levels[8].levelImg.DOAnchorPosX(0, .2f);
        levels[8].levelImg.DOAnchorPosY(450, .2f);
        levels[8].Img.transform.DOScale(1.5f, .2f);

        levels[8].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[8].descriptionCanvas.DOFade(1, .5f);
        levels[8].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[8].exitButton.DOAnchorPosX(-100, .1f);
        levels[8].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel9()
    {
        levels[8].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[8].mask.transform.DOScale(0.1f, .1f);
        levels[8].levelImg.DOAnchorPosX(-106, .1f);
        levels[8].levelImg.DOAnchorPosY(-280, .1f);
        levels[8].Img.transform.DOScale(1.2f, .1f);
        levels[8].exitButton.DOAnchorPosX(-500, .1f);
        levels[8].playButton.DOAnchorPosX(500, .1f);

        levels[8].descriptionCanvas.DOFade(0, .1f);
        levels[8].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[8].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[8].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 10
    public void Level10_onClick()
    {
        StartCoroutine(Level10());
    }
    public void Level10_exit()
    {
        StartCoroutine(RLevel10());
    }

    IEnumerator Level10()
    {
        levels[9].canvas.SetActive(true);
        levels[9].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[9].mask.transform.DOScale(12, .2f);
        levels[9].levelImg.DOAnchorPosX(0, .2f);
        levels[9].levelImg.DOAnchorPosY(450, .2f);
        levels[9].Img.transform.DOScale(1.5f, .2f);

        levels[9].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[9].descriptionCanvas.DOFade(1, .5f);
        levels[9].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[9].exitButton.DOAnchorPosX(-100, .1f);
        levels[9].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel10()
    {
        levels[9].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[9].mask.transform.DOScale(0.1f, .1f);
        levels[9].levelImg.DOAnchorPosX(123, .1f);
        levels[9].levelImg.DOAnchorPosY(-283, .1f);
        levels[9].Img.transform.DOScale(1.2f, .1f);
        levels[9].exitButton.DOAnchorPosX(-500, .1f);
        levels[9].playButton.DOAnchorPosX(500, .1f);

        levels[9].descriptionCanvas.DOFade(0, .1f);
        levels[9].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[9].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[9].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 11
    public void Level11_onClick()
    {
        StartCoroutine(Level11());
    }
    public void Level11_exit()
    {
        StartCoroutine(RLevel11());
    }

    IEnumerator Level11()
    {
        levels[10].canvas.SetActive(true);
        levels[10].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[10].mask.transform.DOScale(12, .2f);
        levels[10].levelImg.DOAnchorPosX(0, .2f);
        levels[10].levelImg.DOAnchorPosY(450, .2f);
        levels[10].Img.transform.DOScale(1.5f, .2f);

        levels[10].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[10].descriptionCanvas.DOFade(1, .5f);
        levels[10].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[10].exitButton.DOAnchorPosX(-100, .1f);
        levels[10].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel11()
    {
        levels[10].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[10].mask.transform.DOScale(0.1f, .1f);
        levels[10].levelImg.DOAnchorPosX(-230, .1f);
        levels[10].levelImg.DOAnchorPosY(186, .1f);
        levels[10].Img.transform.DOScale(1.2f, .1f);
        levels[10].exitButton.DOAnchorPosX(-500, .1f);
        levels[10].playButton.DOAnchorPosX(500, .1f);

        levels[10].descriptionCanvas.DOFade(0, .1f);
        levels[10].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[10].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[10].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 12
    public void Level12_onClick()
    {
        StartCoroutine(Level12());
    }
    public void Level12_exit()
    {
        StartCoroutine(RLevel12());
    }

    IEnumerator Level12()
    {
        levels[11].canvas.SetActive(true);
        levels[11].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[11].mask.transform.DOScale(12, .2f);
        levels[11].levelImg.DOAnchorPosX(8, .2f);
        levels[11].levelImg.DOAnchorPosY(450, .2f);
        levels[11].Img.transform.DOScale(1.5f, .2f);

        levels[11].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[11].descriptionCanvas.DOFade(1, .5f);
        levels[11].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[11].exitButton.DOAnchorPosX(-100, .1f);
        levels[11].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel12()
    {
        levels[11].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[11].mask.transform.DOScale(0.1f, .1f);
        levels[11].levelImg.DOAnchorPosX(8, .1f);
        levels[11].levelImg.DOAnchorPosY(185, .1f);
        levels[11].Img.transform.DOScale(1.2f, .1f);
        levels[11].exitButton.DOAnchorPosX(-500, .1f);
        levels[11].playButton.DOAnchorPosX(500, .1f);

        levels[11].descriptionCanvas.DOFade(0, .1f);
        levels[11].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[11].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[11].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 13
    public void Level13_onClick()
    {
        StartCoroutine(Level13());
    }
    public void Level13_exit()
    {
        StartCoroutine(RLevel13());
    }

    IEnumerator Level13()
    {
        levels[12].canvas.SetActive(true);
        levels[12].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[12].mask.transform.DOScale(12, .2f);
        levels[12].levelImg.DOAnchorPosX(0, .2f);
        levels[12].levelImg.DOAnchorPosY(450, .2f);
        levels[12].Img.transform.DOScale(1.5f, .2f);

        levels[12].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[12].descriptionCanvas.DOFade(1, .5f);
        levels[12].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[12].exitButton.DOAnchorPosX(-100, .1f);
        levels[12].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel13()
    {
        levels[12].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[12].mask.transform.DOScale(0.1f, .1f);
        levels[12].levelImg.DOAnchorPosX(222, .1f);
        levels[12].levelImg.DOAnchorPosY(185, .1f);
        levels[12].Img.transform.DOScale(1.2f, .1f);
        levels[12].exitButton.DOAnchorPosX(-500, .1f);
        levels[12].playButton.DOAnchorPosX(500, .1f);

        levels[12].descriptionCanvas.DOFade(0, .1f);
        levels[12].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[12].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[12].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 14
    public void Level14_onClick()
    {
        StartCoroutine(Level14());
    }
    public void Level14_exit()
    {
        StartCoroutine(RLevel14());
    }

    IEnumerator Level14()
    {
        levels[13].canvas.SetActive(true);
        levels[13].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[13].mask.transform.DOScale(12, .2f);
        levels[13].levelImg.DOAnchorPosX(0, .2f);
        levels[13].levelImg.DOAnchorPosY(450, .2f);
        levels[13].Img.transform.DOScale(1.5f, .2f);

        levels[13].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[13].descriptionCanvas.DOFade(1, .5f);
        levels[13].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[13].exitButton.DOAnchorPosX(-100, .1f);
        levels[13].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel14()
    {
        levels[13].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[13].mask.transform.DOScale(0.1f, .1f);
        levels[13].levelImg.DOAnchorPosX(-107, .1f);
        levels[13].levelImg.DOAnchorPosY(32, .1f);
        levels[13].Img.transform.DOScale(1.2f, .1f);
        levels[13].exitButton.DOAnchorPosX(-500, .1f);
        levels[13].playButton.DOAnchorPosX(500, .1f);

        levels[13].descriptionCanvas.DOFade(0, .1f);
        levels[13].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[13].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[13].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 15
    public void Level15_onClick()
    {
        StartCoroutine(Level15());
    }
    public void Level15_exit()
    {
        StartCoroutine(RLevel15());
    }

    IEnumerator Level15()
    {
        levels[14].canvas.SetActive(true);
        levels[14].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[14].mask.transform.DOScale(12, .2f);
        levels[14].levelImg.DOAnchorPosX(0, .2f);
        levels[14].levelImg.DOAnchorPosY(450, .2f);
        levels[14].Img.transform.DOScale(1.5f, .2f);

        levels[14].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[14].descriptionCanvas.DOFade(1, .5f);
        levels[14].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[14].exitButton.DOAnchorPosX(-100, .1f);
        levels[14].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel15()
    {
        levels[14].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[14].mask.transform.DOScale(0.1f, .1f);
        levels[14].levelImg.DOAnchorPosX(123, .1f);
        levels[14].levelImg.DOAnchorPosY(32, .1f);
        levels[14].Img.transform.DOScale(1.2f, .1f);
        levels[14].exitButton.DOAnchorPosX(-500, .1f);
        levels[14].playButton.DOAnchorPosX(500, .1f);

        levels[14].descriptionCanvas.DOFade(0, .1f);
        levels[14].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[14].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[14].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 16
    public void Level16_onClick()
    {
        StartCoroutine(Level16());
    }
    public void Level16_exit()
    {
        StartCoroutine(RLevel16());
    }

    IEnumerator Level16()
    {
        levels[15].canvas.SetActive(true);
        levels[15].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[15].mask.transform.DOScale(12, .2f);
        levels[15].levelImg.DOAnchorPosX(0, .2f);
        levels[15].levelImg.DOAnchorPosY(450, .2f);
        levels[15].Img.transform.DOScale(1.5f, .2f);

        levels[15].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[15].descriptionCanvas.DOFade(1, .5f);
        levels[15].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[15].exitButton.DOAnchorPosX(-100, .1f);
        levels[15].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel16()
    {
        levels[15].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[15].mask.transform.DOScale(0.1f, .1f);
        levels[15].levelImg.DOAnchorPosX(-227, .1f);
        levels[15].levelImg.DOAnchorPosY(-122, .1f);
        levels[15].Img.transform.DOScale(1.2f, .1f);
        levels[15].exitButton.DOAnchorPosX(-500, .1f);
        levels[15].playButton.DOAnchorPosX(500, .1f);

        levels[15].descriptionCanvas.DOFade(0, .1f);
        levels[15].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[15].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[15].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 17
    public void Level17_onClick()
    {
        StartCoroutine(Level17());
    }
    public void Level17_exit()
    {
        StartCoroutine(RLevel17());
    }

    IEnumerator Level17()
    {
        levels[16].canvas.SetActive(true);
        levels[16].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[16].mask.transform.DOScale(12, .2f);
        levels[16].levelImg.DOAnchorPosX(0, .2f);
        levels[16].levelImg.DOAnchorPosY(450, .2f);
        levels[16].Img.transform.DOScale(1.5f, .2f);

        levels[16].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[16].descriptionCanvas.DOFade(1, .5f);
        levels[16].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[16].exitButton.DOAnchorPosX(-100, .1f);
        levels[16].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel17()
    {
        levels[16].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[16].mask.transform.DOScale(0.1f, .1f);
        levels[16].levelImg.DOAnchorPosX(8, .1f);
        levels[16].levelImg.DOAnchorPosY(-123, .1f);
        levels[16].Img.transform.DOScale(1.2f, .1f);
        levels[16].exitButton.DOAnchorPosX(-500, .1f);
        levels[16].playButton.DOAnchorPosX(500, .1f);

        levels[16].descriptionCanvas.DOFade(0, .1f);
        levels[16].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[16].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[16].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 18
    public void Level18_onClick()
    {
        StartCoroutine(Level18());
    }
    public void Level18_exit()
    {
        StartCoroutine(RLevel18());
    }

    IEnumerator Level18()
    {
        levels[17].canvas.SetActive(true);
        levels[17].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[17].mask.transform.DOScale(12, .2f);
        levels[17].levelImg.DOAnchorPosX(0, .2f);
        levels[17].levelImg.DOAnchorPosY(450, .2f);
        levels[17].Img.transform.DOScale(1.5f, .2f);

        levels[17].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[17].descriptionCanvas.DOFade(1, .5f);
        levels[17].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[17].exitButton.DOAnchorPosX(-100, .1f);
        levels[17].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel18()
    {
        levels[17].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[17].mask.transform.DOScale(0.1f, .1f);
        levels[17].levelImg.DOAnchorPosX(211, .1f);
        levels[17].levelImg.DOAnchorPosY(-122, .1f);
        levels[17].Img.transform.DOScale(1.2f, .1f);
        levels[17].exitButton.DOAnchorPosX(-500, .1f);
        levels[17].playButton.DOAnchorPosX(500, .1f);

        levels[17].descriptionCanvas.DOFade(0, .1f);
        levels[17].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[17].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[17].canvas.SetActive(false);
    }
    #endregion
    
    #region Level 19
    public void Level19_onClick()
    {
        StartCoroutine(Level19());
    }
    public void Level19_exit()
    {
        StartCoroutine(RLevel19());
    }

    IEnumerator Level19()
    {
        levels[18].canvas.SetActive(true);
        levels[18].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[18].mask.transform.DOScale(12, .2f);
        levels[18].levelImg.DOAnchorPosX(0, .2f);
        levels[18].levelImg.DOAnchorPosY(450, .2f);
        levels[18].Img.transform.DOScale(1.5f, .2f);

        levels[18].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[18].descriptionCanvas.DOFade(1, .5f);
        levels[18].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[18].exitButton.DOAnchorPosX(-100, .1f);
        levels[18].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel19()
    {
        levels[18].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[18].mask.transform.DOScale(0.1f, .1f);
        levels[18].levelImg.DOAnchorPosX(-106, .1f);
        levels[18].levelImg.DOAnchorPosY(-280, .1f);
        levels[18].Img.transform.DOScale(1.2f, .1f);
        levels[18].exitButton.DOAnchorPosX(-500, .1f);
        levels[18].playButton.DOAnchorPosX(500, .1f);

        levels[18].descriptionCanvas.DOFade(0, .1f);
        levels[18].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[18].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[18].canvas.SetActive(false);
    }
    #endregion

    #region Level 20
    public void Level20_onClick()
    {
        StartCoroutine(Level20());
    }
    public void Level20_exit()
    {
        StartCoroutine(RLevel20());
    }

    IEnumerator Level20()
    {
        levels[19].canvas.SetActive(true);
        levels[19].mask.transform.DOLocalRotate(new Vector3(0, 0, 135), .2f);
        levels[19].mask.transform.DOScale(12, .2f);
        levels[19].levelImg.DOAnchorPosX(0, .2f);
        levels[19].levelImg.DOAnchorPosY(450, .2f);
        levels[19].Img.transform.DOScale(1.5f, .2f);

        levels[19].levelDescription.rectTransform.DOAnchorPosY(180, .5f);
        levels[19].descriptionCanvas.DOFade(1, .5f);
        levels[19].highestScore.rectTransform.DOAnchorPosY(0, .5f);
        yield return new WaitForSeconds(0.1f);
        levels[19].exitButton.DOAnchorPosX(-100, .1f);
        levels[19].playButton.DOAnchorPosX(100, .1f);
    }

    IEnumerator RLevel20()
    {
        levels[19].mask.transform.DOLocalRotate(new Vector3(0, 0, 0), .1f);
        levels[19].mask.transform.DOScale(0.1f, .1f);
        levels[19].levelImg.DOAnchorPosX(123, .1f);
        levels[19].levelImg.DOAnchorPosY(-283, .1f);
        levels[19].Img.transform.DOScale(1.2f, .1f);
        levels[19].exitButton.DOAnchorPosX(-500, .1f);
        levels[19].playButton.DOAnchorPosX(500, .1f);

        levels[19].descriptionCanvas.DOFade(0, .1f);
        levels[19].levelDescription.rectTransform.DOAnchorPosY(-180, .1f);
        levels[19].highestScore.rectTransform.DOAnchorPosY(-180, .1f);
        yield return new WaitForSeconds(0.1f);
        levels[19].canvas.SetActive(false);
    }
    #endregion
}
