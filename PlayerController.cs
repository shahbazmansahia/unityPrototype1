using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // declared private because we don't want them to be very accessible
    private const float KILOMETERCONST = 3.6f;
    private const float MILESCONST = 2.237f;


    [SerializeField] public float velocity = 5.0f;
    [SerializeField] private float horsePower = 0.0f;
    [SerializeField] private float turnSpeed = 25.0f;

    private Rigidbody playerRb;
    //public const float tyreFriction = 0.07f;
    //public const float gravityForce = 9.8f;
    public float horizontalInput;
    public float forwardInput;

    public GameObject wheel1;           // wheel front left
    public GameObject wheel2;           // wheel front right
    public GameObject wheel3;           // wheel back left
    public GameObject wheel4;           // wheel back right

    [SerializeField] private GameObject centreOfMass;

    public TextMeshProUGUI speedoMeterText;
    //Rigidbody rb;
    //private float mass;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
        // DISABLED BECAUSE THIS WAS ACTUALLY MAKING THINGS WORSE!
        //playerRb.centerOfMass = centreOfMass.transform.position;
        //mass = rb.mass;
    }

    // Update is called once per frame
    void FixedUpdate()
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
        //transform.Translate(Vector3.forward * velocity * Time.deltaTime * forwardInput);

        // This makes the transform-Translate approach redundant; We are finally trying the acceleration approach!
        playerRb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);

        // for displaying the speed on the UI
        velocity = Mathf.Round(playerRb.velocity.magnitude * KILOMETERCONST);
        speedoMeterText.text = "Speed: " + velocity;

        // For horizontal mobility
        if (forwardInput != 0)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
            if (forwardInput > 0)
            {
                // disabling for acceleration approach
                //wheelRotate(Vector3.right);
            }
            else
            {
                // disabling for acceleration approach
                //wheelRotate(Vector3.left);
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

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision with " + other.gameObject.name);
    }

    // Disabling the functions below as they are interfering with wheel colliders which are needed for the acceleration approach
    /*
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
    */
}
