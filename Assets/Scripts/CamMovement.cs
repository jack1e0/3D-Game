using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public GameObject upPos;
    public GameObject downPos;
    public GameObject midPos;

    public float speed;

    private bool atMid;
    private bool atTop;
    private bool atBottom;

    void Start()
    {
        atMid = true;
        atTop = false;
        atBottom = false;
    }

    void Update()
    {
        mid();
        top();
        bottom();
    }

    private void mid()
    {
        if (atMid)
        {
            if (Input.GetKey("up"))
            {
                transform.position = Vector3.MoveTowards(transform.position, upPos.transform.position, speed * Time.deltaTime);

            }

            if (Input.GetKey("down"))
            {
                transform.position = Vector3.MoveTowards(transform.position, downPos.transform.position, speed * Time.deltaTime);

            }

            if (transform.position == upPos.transform.position)
            {
                atMid = false;
                atTop = true;
            }

            if (transform.position == downPos.transform.position)
            {
                atMid = false;
                atBottom = true;
            }
        }

    }

    private void top()
    {
        if (atTop)
        {
            if (Input.GetKey("down"))
            {
                transform.position = Vector3.MoveTowards(transform.position, downPos.transform.position, speed * Time.deltaTime);
                atMid = true;

            }
        }
        if (transform.position == midPos.transform.position)
        {
            atMid = true;
            atTop = false;
        }
    }

    private void bottom()
    {
        if (atBottom)
        {
            if (Input.GetKey("up"))
            {
                transform.position = Vector3.MoveTowards(transform.position, upPos.transform.position, speed * Time.deltaTime);
                atMid = true;

            }
        }
        if (transform.position == midPos.transform.position)
        {
            atMid = true;
            atBottom = false;
        }
    }
}
