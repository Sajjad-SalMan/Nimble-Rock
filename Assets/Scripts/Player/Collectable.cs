using System.Collections;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class Collectable : MonoBehaviour
{
    [HideInInspector]
    public int coin_amount;
    public int total_coin;
    public int required_coin;

    public TMP_Text collected_coins_text;
    public TMP_Text total_coins_text;
    public TMP_Text required_coin_text;
    public TMP_Text UI_coin_text;

    public GameObject ui_coin_group;
    private float time = 0.2f;

    public GameObject endLine;
    public GameObject notEndLine;
    private int crystal_num;
    public TMP_Text crystal_num_text;

    public static bool stopTime;
    public Animator animator;
    private void Start()
    {
        endLine.SetActive(false);
        stopTime = false;
    }

    private void Update()
    {
        if(coin_amount >= required_coin)
        {
            endLine.SetActive(true);
        }
        crystal_num = required_coin - coin_amount;
        UI_coin_text.SetText("x " + coin_amount);

        collected_coins_text.SetText(coin_amount.ToString());
        total_coins_text.SetText(total_coin.ToString());
        required_coin_text.SetText(required_coin.ToString());
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coin_amount += 1;
            StartCoroutine(UI_coin_anim());
            if(coin_amount == 1)
            {
                AudioManager.instance.Play("Coin1");
            }
            if (coin_amount == 2)
            {
                AudioManager.instance.Play("Coin2");
            }
            if (coin_amount == 3)
            {
                AudioManager.instance.Play("Coin3");
            }
            if (coin_amount == 4)
            {
                AudioManager.instance.Play("Coin4");
            }
            if (coin_amount >= 5 && coin_amount < required_coin)
            {
                AudioManager.instance.Play("Coin5");
            }
            if (coin_amount >= required_coin)
            {
                AudioManager.instance.Play("Coin6");
            }
        }

        if (other.gameObject.CompareTag("NotEndLine") && coin_amount < required_coin)
        {
            stopTime = true;
            StartCoroutine(Not_level_End_Anim());
            AudioManager.instance.Play("Not End Line");
        }
    }
    IEnumerator UI_coin_anim()
    {
        ui_coin_group.transform.DOLocalMoveY(130, time);
        yield return new WaitForSecondsRealtime(1f);
        ui_coin_group.transform.DOLocalMoveY(80, time);
    }

    IEnumerator Not_level_End_Anim()                    //level hasent ended massage if not enough coins collected
    {
        notEndLine.transform.DOLocalMoveX(0, time);
        crystal_num_text.SetText(crystal_num.ToString());
        yield return new WaitForSecondsRealtime(2f);
        animator.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(.5f);
        GameManager.instance.Restart();
    }
}
