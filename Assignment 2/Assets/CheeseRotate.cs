using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseRotate : MonoBehaviour
{
   
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, 1);
    }
}
