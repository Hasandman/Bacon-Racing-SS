using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduccionVelocidad : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        switch(other.tag)
        {
            case "Player1":
                GameControl.velocidad1 -=GameControl.velocidad1/3;
               
                break;
            case "Player2":
                GameControl.velocidad2 -= GameControl.velocidad2 / 3;
              
                break;

        }
    }
}
