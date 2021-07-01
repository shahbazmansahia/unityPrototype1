using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystemController : MonoBehaviour
{
    public GameObject firstCam;
    public GameObject secondCam;
    public GameObject thirdCam;
    public GameObject[] camVec;
    private int currCam;
    private int numCams;

    // Start is called before the first frame update
    void Start()
    {
        firstCam.gameObject.SetActive(false);
        secondCam.gameObject.SetActive(false);
        thirdCam.gameObject.SetActive(true);

        Debug.Log(camVec.Length);

        numCams = 3;
        camVec[0] = firstCam;
        camVec[1] = secondCam;
        camVec[2] = thirdCam;

        currCam = 0;

        Debug.Log(camVec.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            Debug.Log("C Pressed!");
            camVec[currCam].gameObject.SetActive(false);
            currCam = (currCam + 1) % numCams;
            camVec[currCam].gameObject.SetActive(true);
            Debug.Log("Cam Activation Process Complete!");
            Debug.Log(camVec.Length);
        }
    }
}
