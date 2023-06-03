using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackFadeIn : MonoBehaviour
{
    public static BlackFadeIn instance;
    public Animator animator;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void StartFade()
    {
        animator.SetTrigger("FadeIn");
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
        ClickDoorNextScene.hasExitedGame = false;
    }
}
