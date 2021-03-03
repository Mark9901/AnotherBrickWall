using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    Vector3 respawnPosition = Vector3.zero;
    public Transform player;

    
    void Start()
    {
        respawnPosition = player.position;
    }

   
    void Update()
    {
        
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        if (hit.gameObject.tag == "Checkpoint")
        {
            respawnPosition = player.position;
            Debug.Log("checkpoint");
        }
        else if (hit.gameObject.CompareTag("Deadly"))
        {
            player.position = respawnPosition;
            Debug.Log("deadly");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            respawnPosition = player.position;
            Debug.Log("checkpoint");
        }
    }
}
