using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NidoFinVueltas : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {

        switch (other.tag)
        {
            case "Player1":

                GameControl.vueltasP1 = 4;


                break;
            case "Player2":

                    GameControl.vueltasP2 = 4;

                    break;

        }
    }
}
