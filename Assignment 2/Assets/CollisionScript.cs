using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionScript : MonoBehaviour
{
    Vector3 respawnPosition = Vector3.zero;
    //public Transform firstCheckpoint;
    private CharacterController controller;
    public GameObject boulder;
    private bool hasrolled = false;

    public int cheeseCollected = 0;


    void Start()
    {
        respawnPosition = gameObject.transform.position;
        controller = gameObject.GetComponent<CharacterController>();
    }


    void Update()
    {

    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.CompareTag("Deadly"))
        {
            controller.enabled = false;
            gameObject.transform.position = respawnPosition;
            controller.enabled = true;
            Debug.Log("deadly");
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            respawnPosition = other.gameObject.transform.position;
            Debug.Log("checkpoint");
        }
        if (other.gameObject.tag == "ActivateBoulder" && hasrolled == false)
        {
            boulder.GetComponent<BoulderRoll>().Roll();
            hasrolled = true;
        }
        if (other.gameObject.tag == "Cheese")
        {
            other.gameObject.SetActive(false);
            cheeseCollected++;
            Debug.Log("cheese");
        }

        if (other.gameObject.tag == "EndCheese")
        {
            SceneManager.LoadScene("Main Menu Scene");
        }

    }
}
