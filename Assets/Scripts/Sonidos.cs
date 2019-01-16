using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour {

   
    public AudioSource cerdoMarrano;
   

    public void Update()
    {
        if (Input.GetButtonDown("Jump2") || Input.GetButtonDown("Jump"))
        {
            cerdoMarrano.loop = false;
            cerdoMarrano.Play();

        }
        
    }




}
