using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useDrugs : MonoBehaviour
{
    public AudioSource injectnois;
    public AudioSource cocesniff;
    static public int cocainebag;
    static public int pill;
    static public int injection;
    static public bool high = false;


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha1) && cocainebag >= 1)
        {
            cocainebag--;
            fashionbar.fashion++;
            Debug.Log("h");

            StartCoroutine(cocaine());

        }


        if (Input.GetKeyDown(KeyCode.Alpha3) && injection >= 1)
        {
            injection--;

            injectnois.Play();

            fashionbar.fashion++;

            Debug.Log(fashionbar.fashion);
            Debug.Log("k");

            SC_FPSController.walkingSpeed = 18f;
            Time.timeScale = 0.5f;

            StartCoroutine(injec());
        }


        IEnumerator injec()
        {
            yield return new WaitForSeconds(5);

            SC_FPSController.walkingSpeed = 10f;
            Time.timeScale = 1;
        }

        IEnumerator cocaine()
        {
            cocesniff.Play();
            yield return new WaitForSeconds(1.5f);
            SC_FPSController.walkingSpeed = 20;
            high = true;
            yield return new WaitForSeconds(5);
            high = false;
            SC_FPSController.walkingSpeed = 10f;
        }
    }
}
