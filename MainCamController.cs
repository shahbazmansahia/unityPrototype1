using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamController : MonoBehaviour
{
    public GameObject player;
    public GameObject firstCam;
    public GameObject secondCam;
    public GameObject thirdCam;
    public GameObject [] camVec;
    private int currCam;
    private int numCams;
    private Vector3 camOffFirst;
    private Vector3 camOffSecond;
    private Vector3 camOffThird;
    private Vector3[] camOffVec;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        firstCam.gameObject.SetActive(true);
        secondCam.gameObject.SetActive(false);
        thirdCam.gameObject.SetActive(false);
        
        numCams = 3;
        camVec[0] = firstCam;
        camVec[1] = secondCam;
        camVec[2] = thirdCam;

        currCam = 0;
        
        camOffFirst = new Vector3(0, 7, -12);
        camOffSecond = new Vector3(-0.3f, 0.86f, -7.9f);
        camOffThird = new Vector3(-3, 1.95f, 10.5f);
        offset = camOffFirst;
        camOffVec[0] = camOffFirst;
        camOffVec[1] = camOffSecond;
        camOffVec[2] = camOffThird;
    }

    private void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            camVec[currCam].gameObject.SetActive(false);
            currCam = (currCam + 1) % numCams;
            camVec[currCam].gameObject.SetActive(true);
            offset = camOffVec[currCam];
        }
    }

    // LateUpdate is called once per frame after the Update method
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
