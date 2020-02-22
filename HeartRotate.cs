using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRotate : MonoBehaviour
{
    public int rotateSpeed = 2;




    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, rotateSpeed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, -2*(rotateSpeed-1), 0);
        }

    }
}
