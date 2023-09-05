using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_item : MonoBehaviour
{

    public GameObject objectToSpawn;
    public Vector3 minPosition;
    public Vector3 maxPosition;
    void Start()
    {

    }

    // Update is called once per frame
    
    public float interval = 5;
    float timer;
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= interval)
        {
            Vector3 randomPosition = new Vector3(
        Random.Range(minPosition.x, maxPosition.x),
        Random.Range(minPosition.y, maxPosition.y),
        Random.Range(minPosition.z, maxPosition.z)
    );

            // Spawn an object
            Instantiate(objectToSpawn, randomPosition, Random.rotation);
            timer -= interval;
            // Reset the timer
        }
    }
}
