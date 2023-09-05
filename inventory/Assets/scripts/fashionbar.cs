using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fashionbar : MonoBehaviour
{
    public GameObject human;
    
    public const float maxfashion = 10f;

    static public float fashion = 0;

    private Image bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = (fashion/maxfashion);
        if (fashion == 10f)
        {
            fashion++;
            
            FindObjectOfType<SC_FPSController>().canMove = false;

            human.AddComponent<Rigidbody>();
        }
    }
}
