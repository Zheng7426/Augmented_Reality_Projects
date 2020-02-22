using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beating : MonoBehaviour
{
    public float scaleSpeed = 0.3f;
    private Vector3 scaleChange;



    void Start()
    {
        scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
    }

    void Update()
    {
        transform.localScale += scaleSpeed * scaleChange;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            scaleSpeed += 0.01f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            scaleSpeed -= 0.01f;
        }
        if (transform.localScale.y < 0.1f || transform.localScale.y > 1.0f)
        {
            scaleChange = -scaleChange;
        }


    }
}

