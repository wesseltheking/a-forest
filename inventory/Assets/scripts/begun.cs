using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class begun : MonoBehaviour
{
    // Start is called before the first frame update
    public void Playgame()
    {
        FindObjectOfType<fadeToBlack>().fade();
        StartCoroutine(start());

        IEnumerator start()
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Quitgame()
    {
        AppHelper.Quit();
    }
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
