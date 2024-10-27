using UnityEngine;

public class SoftLockTrigger : MonoBehaviour
{
    public GameObject softLock;
    public GameObject unlocked;

    private BoxCollider2D box;
    private CapsuleCollider2D capsule;

    public static bool finishLine;

    private void Start()
    {
        softLock.SetActive(true);
        unlocked.SetActive(false);

        box = GetComponent<BoxCollider2D>();
        capsule = GetComponent<CapsuleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(box.IsTouching(collision) && PlayerPrefs.GetInt("LevelReached") >= 12)
        {
            softLock.SetActive(false);
            unlocked.SetActive(true);
        }

        if (capsule.IsTouching(collision))
        {
            finishLine = true;
            Invoke("GameFinished", 8f);
        }
    }

    private void GameFinished()
    {
        if (finishLine)
        {
            LevelComplete.LevelEnded = true;
        }
    }
}
