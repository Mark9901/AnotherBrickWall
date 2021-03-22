using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderRoll : MonoBehaviour
{

    private Rigidbody rb;

    private bool roll = false;
    private float timer = 0.0f;
    public float timeRolling;
    public float amountOfForce;
    private bool roll2 = false;
    private float timers = 0.0f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); 
    }

    
    void Update()
    {
        if(roll == true)
        {
            timer += Time.deltaTime;
        }


        if(timer <= timeRolling && roll == true)
        {
            rb.AddForce(Vector3.left* amountOfForce);
        }

        if (roll2 == true)
        {
            timers += Time.deltaTime;
        }


        if (timers <= timeRolling && roll2 == true)
        {
            rb.AddForce(Vector3.left * amountOfForce);
        }


    }


    public void Roll()
    {
        roll = true;
    }
    public void Roll2()
    {
        roll2 = true;
    }
}
