using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController2 : MonoBehaviour
{
    public float velocity = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * velocity * Time.deltaTime);
    }
}
