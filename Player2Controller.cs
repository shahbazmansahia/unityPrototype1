using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    // declared private because we don't want them to be very accessible
    public float velocity = 5.0f;
    //public float acceleration = 0.0f;
    private float turnSpeed = 25.0f;
    //public const float tyreFriction = 0.07f;
    //public const float gravityForce = 9.8f;
    private float horizontalInput;
    private float forwardInput;
    //Rigidbody rb;
    //private float mass;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //mass = rb.mass;
    }

    // Update is called once per frame
    void Update()
    {
        // For getting the input and translating it into movement values
        horizontalInput = Input.GetAxis("Horizontal2");
        forwardInput = Input.GetAxis("Vertical2");
        /*  Tried to add force-based acceleration
        if ((velocity > 0) && (forwardInput > 0))
        {
            acceleration += (velocity > 0) ? forwardInput - (tyreFriction * gravityForce) : 0;
        }
        velocity = Time.deltaTime * acceleration;
        */
        // Move the vehicle forward
        transform.Translate(Vector3.forward * velocity * Time.deltaTime * forwardInput);
        // For horizontal mobility
        if (forwardInput != 0)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
        
    }
}
