using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShift : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
