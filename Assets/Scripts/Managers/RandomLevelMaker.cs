using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevelMaker : MonoBehaviour
{
    public List<Vector2> positions;
    public GameObject[] prefabs;
    [HideInInspector]
    public List<GameObject> clones;

    private void Start()
    {
        AssignPositions();
    }
    private void AssignPositions()
    {
        for (int i = prefabs.Length - 1; i >= 0; i--)
        {
            int index = Random.Range(0, positions.Count);

            prefabs[i].transform.position = positions[index];
            GameObject clone = Instantiate(prefabs[i], positions[index], Quaternion.identity);
            positions.RemoveAt(index);
            clones.Add(clone);
        }
    }
}
