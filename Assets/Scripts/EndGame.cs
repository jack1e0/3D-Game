using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndGame : MonoBehaviour
{
    public static EndGame instance;
    public Animator animator;
    public Texture2D cursor;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void End()
    {
        animator.SetTrigger("HasEnded");
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    public void GameEnd()
    {
        animator.SetTrigger("hasFaded");
    }
}
