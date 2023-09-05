using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class grab_casing : MonoBehaviour
{
    static public bool dedtransit = false;
    public int bulletcount;
    public Text score;
    public string bullets;

    public AudioSource pickup;

    public GameObject player2;

    public GameObject key1;
    public GameObject key2;
    public GameObject key3;

    public GameObject fahsionPickup;

    //public int pill(this is inside useDrugs.cs)
     public Text pill;
     static public string pillText;

    //public int inject(this is inside useDrugs.cs)
     public Text inject;
     static public string injectText;

    //public int cocainebag(this is inside useDrugs.cs)
     public Text cocaine;
     static public string cocainText;


    public int keynum;
    public Text keytext;
    public string key;

    void Start()
    {
        key1.SetActive(false);
        key2.SetActive(false);
        key3.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bulet")
        {
            pickup.Play();
            Destroy(other.gameObject);
            bulletcount++;

            bullets = Convert.ToString(bulletcount);
            score.text = bullets;
            Debug.Log(bulletcount);
        }
        else if (other.tag == "key1")
        {
            pickup.Play();
            Destroy(other.gameObject);
            keynum++;
            key1.SetActive(true);
            key = Convert.ToString(keynum);
            Debug.Log(keynum);
        }
        else if (other.tag == "key2")
        {
            pickup.Play();
            Destroy(other.gameObject);
            keynum++;
            key2.SetActive(true);
            key = Convert.ToString(keynum);
            Debug.Log(keynum);

        }
        else if (other.tag == "key3")
        {
            pickup.Play();
            Destroy(other.gameObject);
            keynum++;
            key3.SetActive(true);
            key = Convert.ToString(keynum);
            Debug.Log(keynum);

        }
        else if (other.tag == "dor")
        {
            if (keynum == 3)
            {
                FindObjectOfType<openDoor>().open();
            }
        }
        else if (other.tag == "fashion")
        {
            Destroy(other.gameObject);
            fashionbar.fashion++;
        }
        else if (other.tag == "cocaine")
        {
            pickup.Play();
            Destroy(other.gameObject);
            useDrugs.cocainebag++;

            cocainText = Convert.ToString(useDrugs.cocainebag);
            cocaine.text = cocainText;

            Debug.Log(useDrugs.cocainebag);
        }
        else if (other.tag == "pill")
        {
            pickup.Play();
            Destroy(other.gameObject);
            useDrugs.pill++;

            pillText = Convert.ToString(useDrugs.pill);
            pill.text = pillText;

            Debug.Log(useDrugs.pill);
        }
        else if (other.tag == "injection")
        {
            pickup.Play();
            Destroy(other.gameObject);
            useDrugs.injection++;

            injectText = Convert.ToString(useDrugs.injection);
            inject.text = injectText;
            Debug.Log(useDrugs.injection);
        }
        else if (other.tag == "end")
        {
            FindObjectOfType<fadeToBlack>().fade();
            StartCoroutine(end());
        }
        IEnumerator end()
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3) && useDrugs.injection >= 1)
        {
            StartCoroutine(injec());

        }

        IEnumerator injec()
        {
            yield return new WaitForEndOfFrame();
            injectText = Convert.ToString(useDrugs.injection);
            inject.text = injectText;
        }      

        if (Input.GetKeyDown(KeyCode.Alpha1) && useDrugs.cocainebag >= 1)
        {
            StartCoroutine(cocane());

        }

        IEnumerator cocane()
        {
            yield return new WaitForEndOfFrame();
            cocainText = Convert.ToString(useDrugs.cocainebag);
            cocaine.text = cocainText;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && useDrugs.pill >= 1)
        {
            StartCoroutine(pil());

        }

        IEnumerator pil()
        {
            yield return new WaitForEndOfFrame();
            pillText = Convert.ToString(useDrugs.pill);
            pill.text = pillText;
        }

        if(dedtransit == true)
        {
            StartCoroutine(dedtrans());
        }

        IEnumerator dedtrans()
        {
            FindObjectOfType<SC_FPSController>().canMove = false;
            player2 = GameObject.FindGameObjectWithTag("Player").gameObject;

            player2.AddComponent<Rigidbody>();
            FindObjectOfType<fadeToBlack>().fade();
            yield return new WaitForSeconds(5);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            dedtransit = false;
            chaseState.ded = false;
            fashionbar.fashion = 0;
            useDrugs.pill = 0;
            useDrugs.cocainebag = 0;
            useDrugs.injection = 0;
            keynum = 0;
            bulletcount = 0;
        }
    }

}