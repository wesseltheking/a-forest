using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treespawn : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> treesToSpawn = new List<GameObject>();
    public Vector3 minPosition;
    public Vector3 maxPosition;
    public int amountOfTrees;
    void Start()
    {
        
        for (int i = 0; i < amountOfTrees; i++)
        {
            float randomNumber = Random.Range(0, 360);
            Vector3 randomPosition = new Vector3(
            Random.Range(minPosition.x, maxPosition.x),
            Random.Range(minPosition.y, maxPosition.y),
            Random.Range(minPosition.z, maxPosition.z)
            );

            GameObject tree = treesToSpawn[Random.Range(0, treesToSpawn.Count)];
            Instantiate(tree, randomPosition, Quaternion.Euler(new Vector3(270,randomNumber,0)));
        }
    }
}
