using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroController : MonoBehaviour {

    private Vector3 Pos = new Vector3(0, 0, 0);
    // Use this for initialization
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Debug.Log(Input.gyro.attitude);
    }
    void Update()
    {
        transform.rotation = Input.gyro.attitude;
    }
}
