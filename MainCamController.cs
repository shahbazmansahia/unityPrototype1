using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamController : MonoBehaviour
{
    public GameObject player;
    public GameObject secondCam;
    private Vector3 offset = new Vector3(0, 7, -12);
    // Start is called before the first frame update
    void Start()
    {
        secondCam.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
