using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCamController : MonoBehaviour
{
    public GameObject player;
    /*
    private Vector3 camOffFirst;
    private Vector3 camOffSecond;
    private Vector3 camOffThird;
    private Vector3[] camOffVec;
    */
    [SerializeField] private Vector3 offset = new Vector3(3.014480847f, 0.79f, -7.66f);
    //private Vector3 offRotation = new Vector3 (Vector3.up, 11.0);
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.up, 11.0f);
        transform.position = player.transform.position + offset;
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
