using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarVueltas : MonoBehaviour {

    public Text vueltas1;
    public Text vueltas2;
   

    private void Start()
    {
        actualizarVueltas();
    }

    private void Update()
    {
        actualizarVueltas();
    }

    void actualizarVueltas()
    {
        vueltas1.text = "Lap: " + GameControl.vueltasP1 +"/3";
        vueltas2.text = "Lap: " + GameControl.vueltasP2 +"/3";
    }
}
