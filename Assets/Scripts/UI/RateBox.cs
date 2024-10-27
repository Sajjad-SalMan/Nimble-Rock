using UnityEngine;
using DG.Tweening;

public class RateBox : MonoBehaviour
{
    public void NoThanks()
    {
        gameObject.SetActive(false);
    }
    public void RateNow()
    {
        Application.OpenURL("market://details?id=com.Arcque.NimbleRock");
        gameObject.SetActive(false);
    }
}
