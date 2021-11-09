using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    private Vector3 dir = Vector3.left;
    private float speed = 5.0f;
    //Your Update function
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.x <= 184)
        {
            dir = Vector3.right;
        }
        else if (transform.position.x >= 200)
        {
            dir = Vector3.left;
        }
    }

}
