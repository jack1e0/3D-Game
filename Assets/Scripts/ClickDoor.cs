using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickDoor : MonoBehaviour
{
    public Texture2D cursor1;
    public Texture2D cursor2;

    public static bool exit = false;

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
        BlackFadeIn.instance.StartFade();
    }
}
