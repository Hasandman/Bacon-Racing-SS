using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectosSonido : MonoBehaviour {


    public AudioSource macetas;
    public AudioSource madera;
    public AudioSource metal;

    public void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "Plantas":
                Debug.Log("chocastePLantas");
                macetas.loop = true;
                macetas.Play();
                break;
            case "Madera":
                madera.loop = true;
                madera.Play();
                break;
            case "Metal":
                metal.loop = true;
                metal.Play();
                break;

            default:
                macetas.Stop();
                metal.Stop();
                madera.Stop();
                break;

        }
      
    }
}
