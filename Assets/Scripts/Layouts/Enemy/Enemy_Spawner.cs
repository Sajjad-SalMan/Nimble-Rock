using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject spawn;

    [SerializeField] private float endvalue;
    [SerializeField] private float duration;
    [SerializeField] private GameObject crack;
    [SerializeField] private GameObject circle;

    private SpriteRenderer crackSprite;
    private SpriteRenderer circlesprite;
    private ParticleSystem ps;
    private BoxCollider2D boxCollider;
    private void Start()
    {
        crackSprite = crack.GetComponent<SpriteRenderer>();
        circlesprite = circle.GetComponent<SpriteRenderer>();
        ps = GetComponentInChildren<ParticleSystem>();
        boxCollider = GetComponent<BoxCollider2D>();

        circlesprite.enabled = true;
        crackSprite.enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spawn.transform.DOMoveX(spawn.transform.position.x + endvalue, duration);
            ps.Play();
            crackSprite.enabled = false;
            circlesprite.enabled = false;
            Destroy(boxCollider);
        }
    }
}
