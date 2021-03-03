using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdPlayer : MonoBehaviour
{
    void OnTriggerStay(Collider col) {
         col.transform.parent = gameObject.transform;
     }
 
     void OnTriggerExit(Collider col)
     {
         col.transform.parent = null;
     }
}
