using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCamController : MonoBehaviour
{
    public GameObject player;
    /*
    private Vector3 camOffFirst;
    private Vector3 camOffSecond;
    private Vector3 camOffThird;
    private Vector3[] camOffVec;
    */
    private Vector3 offset = new Vector3(0.0f, 1.95f, 2.977f);
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {

    }

    // LateUpdate is called once per frame after the Update method
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
