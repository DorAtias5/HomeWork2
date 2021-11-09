using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody rg;
    public float verticalInput;
    public float horizontalInput;
    [SerializeField]
    public float speed = 10.0f;

    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {

        rg.AddForce(new Vector3(horizontalInput, 0, verticalInput)*speed);

    }
}
