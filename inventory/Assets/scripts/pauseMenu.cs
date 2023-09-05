using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
    }
    public void backmenu()
    {
        FindObjectOfType<fadeToBlack>().fade();
        StartCoroutine(back());

        IEnumerator back()
        {
            yield return new WaitForSeconds(3);
            pause.SetActive(false);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    public void resume()
    {
        pause.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        FindObjectOfType<SC_FPSController>().canMove = true;
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause.activeSelf)
            {
                pause.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                FindObjectOfType<SC_FPSController>().canMove = true;
                Cursor.visible = false;
            }
            else
            {
                pause.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                FindObjectOfType<SC_FPSController>().canMove = false;
                Cursor.visible = true;

            }
        }
    }
}
