using UnityEngine;
using DG.Tweening;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] private Canvas blocker;
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject both;
    [SerializeField] private CanvasGroup bothCanvas;

    private void Start()
    {
        blocker.enabled = false;
        text.SetActive(true);
    }

    private void Update()
    {
        if(PlayerController.startPhase == false)
        {
            blocker.enabled = true;
            ActivateBoth();
            text.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bothCanvas.DOFade(0, .5f);
        }
    }

    private void ActivateBoth()
    {
        blocker.enabled = false;
        both.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.Home();
        }
    }
}
