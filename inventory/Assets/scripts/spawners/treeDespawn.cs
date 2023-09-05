using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeDespawn : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "tree")
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame

}
