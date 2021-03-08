using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class creditsclose : MonoBehaviour
{
    public GameObject playdisable;
    public GameObject creditimage;
    public GameObject creditdisable;
    public GameObject exitdisable;


    public void Credits()
    {
        playdisable.SetActive(false);
        creditimage.SetActive(true);
        exitdisable.SetActive(false);
        creditdisable.SetActive(false);

        

    }
    public void Return()
    {
        playdisable.SetActive(true);
        creditimage.SetActive(false);
        exitdisable.SetActive(true);
        creditdisable.SetActive(true);

       
    }
}

