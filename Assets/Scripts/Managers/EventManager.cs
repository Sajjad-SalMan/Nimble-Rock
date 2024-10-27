using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class EventManager : MonoBehaviour
{
    public static EventManager instance;

    public GameObject rateBox;

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

    public void ShowRateBox()   //this gets called in Level Complete
    {
        Invoke("AnimRateBox", 3f);
    }

    void AnimRateBox()
    {
        rateBox.SetActive(true);
        rateBox.transform.DOScale(1, .5f).SetEase(Ease.OutBounce);
    }
}
