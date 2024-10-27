using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LIfeIngameUI : MonoBehaviour
{
    public Toggle[] hearts;
    public int died;

    void Update()
    {
        for (int i = 0; i < died; i++)
        {
            foreach (var heart in hearts)
            {
                heart.isOn = true;
            }
        }
    }
}
