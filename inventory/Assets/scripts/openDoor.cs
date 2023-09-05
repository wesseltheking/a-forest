using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    //animator
    public Animator smalldor;
    public AudioSource gatenoise;

    public void open()
    {
        StartCoroutine(dor());
    }

    IEnumerator dor()
    {
        smalldor.SetTrigger("OPEN");
        gatenoise.Play();
        yield return new WaitForSeconds(1);
    }
}
