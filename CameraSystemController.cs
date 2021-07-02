using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystemController : MonoBehaviour
{
    public Camera firstCam;
    public Camera secondCam;
    public Camera thirdCam;
    //public GameObject[] camVec;               //Tried to implement using an array but ran into issues. Implemented it using a simpler process instead.

    private int currCam;
    private int numCams;
    private int numPlayers;
    private Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {        
        firstCam.gameObject.SetActive(true);
        secondCam.gameObject.SetActive(false);
        thirdCam.gameObject.SetActive(false);
        mainCam = firstCam;

        firstCam.rect = new Rect((0), (0), 0.5f, 1.0f);
        secondCam.rect = new Rect((0), (0), 0.5f, 1.0f);
        thirdCam.rect = new Rect((0), (0), 0.5f, 1.0f);
        //Debug.Log(camVec.Length);
        numCams = 3;
        currCam = 0;
        numPlayers = 2;

        Debug.Log(Screen.width);
        Debug.Log(Screen.height);
        /*
        
        camVec[0] = firstCam;
        camVec[1] = secondCam;
        camVec[2] = thirdCam;

        

        Debug.Log(camVec.Length);
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            Debug.Log("C Pressed!");
            
            currCam++;
            currCam %= numCams;
            //camVec[currCam].gameObject.SetActive(false);
            //currCam = (currCam + 1) % numCams;
            //camVec[currCam].gameObject.SetActive(true);
            switch (currCam)
            {
                case 0:
                    firstCam.gameObject.SetActive(true);
                    thirdCam.gameObject.SetActive(false);
                    //firstCam.rect = new Rect((0), (0), 0.5f, 1.0f);
                    mainCam = firstCam;
                    break;

                case 1:
                    secondCam.gameObject.SetActive(true);
                    firstCam.gameObject.SetActive(false);
                    //secondCam.rect = new Rect((0), (0), (Screen.width / 2), (Screen.height));
                    mainCam = secondCam;
                    break;

                case 2:
                    thirdCam.gameObject.SetActive(true);
                    secondCam.gameObject.SetActive(false);
                    //thirdCam.rect = new Rect((0), (0), (Screen.width / 2), (Screen.height));
                    mainCam = thirdCam;
                    break;

                default:
                    Debug.Log("ERROR: CAMERA SWITCH MECHANISM HAS A PROBLEM!");
                    break;
            }

            if (Input.GetKey("space"))
            {
                Debug.Log("Space pressed!");
                mainCam.rect = new Rect(0.49f, 0.0f, 1.0f -  0.49f * 2.0f, 1.0f);
            }
            Debug.Log("Cam Activation Process Complete!");
            //Debug.Log(camVec.Length);
        }
    }
}
