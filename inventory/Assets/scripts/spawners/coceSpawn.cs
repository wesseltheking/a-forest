using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coceSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public Vector3 minPosition;
    public Vector3 maxPosition;
    public int amount = 20;
    void Start()
    {

        for (int i = 0; i < amount; i++)
        {
            float randomNumber = Random.Range(0, 360);
            Vector3 randomPosition = new Vector3(
            Random.Range(minPosition.x, maxPosition.x),
            Random.Range(minPosition.y, maxPosition.y),
            Random.Range(minPosition.z, maxPosition.z)
         );
            Instantiate(objectToSpawn, randomPosition, Quaternion.Euler(new Vector3(0, randomNumber, 0)));
        }
    }
}
