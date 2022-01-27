using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraScript : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        // Update camera rotation
        yaw += speedH * Input.GetAxis("Mouse X");

        pitch -= speedV * Input.GetAxis("Mouse Y");
        // Make sure camera can't rotate too far up or down
        pitch = Mathf.Clamp(pitch, -90, 90);

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}


