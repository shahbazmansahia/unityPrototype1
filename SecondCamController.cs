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
    private Vector3 offset = new Vector3(-0.008480847f, 0.2825598f, 0.5333438f);
    private Vector3 offRotation = new Vector3 (-18.529f, -19.115f, 0);
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(offRotation);
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
