using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeIGU : MonoBehaviour
{
    [SerializeField]
    public Toggle[] hearts;
    private int died;

    private int lifeGraphics;

    // Update is called once per frame

    void Update()
    {
        if (died < Respawn.died)
        {
            died++;
            hearts[lifeGraphics].isOn = true;
            lifeGraphics++;
            if (lifeGraphics > 2)
            {
                lifeGraphics = 2;
            }
        }
        if (RewardedAdsButton.reviving)
        {
            hearts[2].isOn = false;
        }
    }
}
