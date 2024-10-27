using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessSpawnController : MonoBehaviour
{
    [SerializeField] private List<BoxCollider2D> activeColliders;
    [SerializeField] private GameObject[] PrefabSets;
    private GameObject endlessprefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (BoxCollider2D c in activeColliders)
        {
            int index;

            if (c.IsTouching(collision))
            {
                index = activeColliders.IndexOf(c);
                PrefabSets[index + 1].SetActive(true);
                StartCoroutine(WaitBeforeDestroy(index));
                Debug.Log(index);
            }
        }
    }

    private IEnumerator WaitBeforeDestroy(int prefab)
    {
        yield return new WaitForSeconds(1f);
        List<GameObject> prefabClone = PrefabSets[prefab].gameObject.GetComponent<RandomLevelMaker>().clones;
        foreach (GameObject c in prefabClone)
        {
            c.SetActive(false);
        }
    }
}
