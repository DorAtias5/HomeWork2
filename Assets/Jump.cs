using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{   
    [SerializeField]
    private float jumpSpeed = 5;
    private Rigidbody rigiBody;
    private bool onGround = true;
    void Start()
    {
        rigiBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")&& onGround)
        {
            rigiBody.AddForce(Vector3.up*jumpSpeed, ForceMode.Impulse);
            onGround = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }
}
