using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    // declared private because we don't want them to be very accessible
    public float velocity = 5.0f;
    //public float acceleration = 0.0f;
    private float turnSpeed = 25.0f;
    //public const float tyreFriction = 0.07f;
    //public const float gravityForce = 9.8f;
    public float horizontalInput;
    public float forwardInput;

    public GameObject wheel1;           // wheel front left
    public GameObject wheel2;           // wheel front right
    public GameObject wheel3;           // wheel back left
    public GameObject wheel4;           // wheel back right


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
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
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
            if (forwardInput > 0)
            {
                wheelRotate(Vector3.right);
            }
            else
            {
                wheelRotate(Vector3.left);
            }
            /*
            if (horizontalInput > 0)
            {
                wheelTurn(Vector3.up);
            }
            else
            {
                wheelTurn(Vector3.down);
            }
            */
        }
        
    }

    void wheelRotate(Vector3 direction)
    {
        float wheelSpeed = 50.0f;
        wheel1.transform.Rotate(direction, forwardInput * Time.deltaTime * velocity * wheelSpeed);
        wheel2.transform.Rotate(direction, forwardInput * Time.deltaTime * velocity * wheelSpeed);
        wheel3.transform.Rotate(direction, forwardInput * Time.deltaTime * velocity * wheelSpeed);
        wheel4.transform.Rotate(direction, forwardInput * Time.deltaTime * velocity * wheelSpeed);

    }
    void wheelTurn (Vector3 direction)
    {
        float wheelSpeed = 50.0f;
        wheel1.transform.Rotate(direction, forwardInput * Time.deltaTime * velocity * wheelSpeed);
        wheel2.transform.Rotate(direction, forwardInput * Time.deltaTime * velocity * wheelSpeed);

    }
}
