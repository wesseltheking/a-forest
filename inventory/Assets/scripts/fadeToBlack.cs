using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeToBlack : MonoBehaviour
{
    public Animator fabla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fade()
    {
        StartCoroutine(fad());
    }

    IEnumerator fad()
    {
        fabla.SetTrigger("fadeblack");
        yield return new WaitForSeconds(1);
        fabla.SetTrigger("idle");
    }
}
