using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class MouseLook : MonoBehaviour
{
    public float mousesensitivity = 200.0f;
    private float LookAtPosition = 0.0f;
    private float yRotation = 0.0f;
    public Transform lookAt;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousesensitivity * Time.deltaTime;
        yRotation -= mouseX;
        yRotation = Mathf.Clamp(yRotation, -90.0f, 90.0f);
        transform.Rotate(Vector3.up, mouseX);

        float mouseY = Input.GetAxis("Mouse Y") * mousesensitivity * Time.deltaTime;
        LookAtPosition -= mouseY;
        LookAtPosition = Mathf.Clamp(LookAtPosition, 1.0f, 60.0f);
        lookAt.transform.localRotation= Quaternion.Euler(LookAtPosition, 0, 0);







        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Cursor.lockstate = CursorLockMode.None;
        //    Cursor.visible = true;
        //}

    }
}
