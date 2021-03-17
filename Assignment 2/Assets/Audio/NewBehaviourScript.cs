using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetsound : MonoBehaviour
{
    public AudioSource audio;

    void Start()
    {
       
        audio = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "cheese")
        {
            audio.Play();
            Destroy(gameObject);
        }
    }
}