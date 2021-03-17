using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusic : MonoBehaviour
{
    private float loopTimer = 200.0f;


    void Start()
    {
        
    }

    
    void Update()
    {
        loopTimer += Time.deltaTime;

        if (loopTimer >= 201)
        {
            SoundManager.PlaySound("MainMusic");
            loopTimer = 0.0f;
        }
       
    }
}
