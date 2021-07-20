using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamController : MonoBehaviour
{
    public GameObject player;
    /*
    private Vector3 camOffFirst;
    private Vector3 camOffSecond;
    private Vector3 camOffThird;
    private Vector3[] camOffVec;
    */
    [SerializeField] private Vector3 offset = new Vector3(0, 7, -12);
    // Start is called before the first frame update
    void Start()
    {
        
        /*
        camOffFirst = new Vector3(0, 7, -12);
        camOffThird = new Vector3(-3, 1.95f, 10.5f);
        offset = camOffFirst;
        camOffVec[0] = camOffFirst;
        camOffVec[1] = camOffSecond;
        camOffVec[2] = camOffThird;
        */
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
