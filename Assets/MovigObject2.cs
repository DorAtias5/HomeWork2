using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovigObject2 : MonoBehaviour
{

    private Vector3 dir = Vector3.left;
    private float speed = 5.0f;
    //Your Update function
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.x <= 163)
        {
            dir = Vector3.right;
        }
        else if (transform.position.x >= 186.5)
        {
            dir = Vector3.left;
        }
    }

}
