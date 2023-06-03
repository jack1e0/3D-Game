using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDoorNextScene : MonoBehaviour
{
    public Texture2D cursor1;
    public Texture2D cursor2;

    public Animator animator;

    public static bool hasExitedGame = false;

    void Start()
    {
        Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
    }

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursor2, Vector2.zero, CursorMode.Auto);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
    }

    private void OnMouseDown()
    {
        animator.SetTrigger("ExitGame");
        StartCoroutine(Fading());
    }

    private IEnumerator Fading()
    {
        hasExitedGame = true;
        EndGame.instance.End();
        yield return new WaitForSeconds(1);
    }
}
