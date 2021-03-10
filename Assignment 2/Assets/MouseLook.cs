using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class MouseLook : MonoBehaviour
{
    public float mousesensitivity = 200.0f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    public CinemachineVirtualCamera vcam;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousesensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesensitivity * Time.deltaTime;

        xRotation -= mouseY;
        yRotation -= mouseX;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);
        yRotation = Mathf.Clamp(yRotation, -90.0f, 90.0f);

        vcam.transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        transform.Rotate(Vector3.up, mouseX);
        transform.Rotate(Vector3.right, mouseY);



        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Cursor.lockstate = CursorLockMode.None;
        //    Cursor.visible = true;
        //}

    }
}
