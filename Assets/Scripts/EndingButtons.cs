using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingButtons : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
        ClickDoor.exit = false;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
