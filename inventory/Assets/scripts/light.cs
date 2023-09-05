using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class light : MonoBehaviour
{
	Light llight;

	void Start()
	{
		llight = GetComponent<Light>();
	}

	void Update()
	{


		if (Input.GetKeyDown(KeyCode.Alpha2) && useDrugs.pill >= 1)
		{
			fashionbar.fashion++;
			useDrugs.pill--;

			llight.enabled = !llight.enabled;
			Debug.Log("j");

			StartCoroutine(pills());
		}


		IEnumerator pills()
		{
			yield return new WaitForSeconds(10);
			llight.enabled = !llight.enabled;
		}
	}
}