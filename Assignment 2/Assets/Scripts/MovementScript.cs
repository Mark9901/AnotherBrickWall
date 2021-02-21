using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody rb;
    public float movementspeed;
    public float jumpforce;
    public bool grounded = false;
    public bool isjumping = false;

  

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (grounded == true)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            rb.velocity = transform.right * x + transform.forward * z;
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            isjumping = true;
            StartCoroutine(JumpingStartAndStop());
        }

        if (isjumping == true)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Acceleration);
        }




    }

    private IEnumerator JumpingStartAndStop()
    {
        yield return new WaitForSeconds(0.1f);
        isjumping = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}
