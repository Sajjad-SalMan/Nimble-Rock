using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCryslatAnim : MonoBehaviour
{
    public GameObject redPoint;
    public GameObject bluePoint;

    public bool trigger;
    private void Update()
    {
        if (trigger)
        {
            redPoint.SetActive(false);
            bluePoint.SetActive(true);
        }
        else
        {
            redPoint.SetActive(true);
            bluePoint.SetActive(false);
        }
    }

}
