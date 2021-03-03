using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdplayer2 : MonoBehaviour
{

    void OnTriggerExit(Collider other)
{
    if(other.gameObject.tag == "Player")
{
other.transform.parent = null;
}
}

 void OnTriggerEnter(Collider other)
{
    if(other.gameObject.tag == "Player")
{
other.transform.parent = transform;
}
}

}
