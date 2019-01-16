using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarVelocidad : MonoBehaviour {


    public Text velocimetro;
    public  GameObject reversa;
    public Movimiento mov;

    private void Start()
    {
        actualizarVelocidad();
    }

    void actualizarVelocidad()
    {
        velocimetro.text = " " + GameControl.velocidad2 + " Km/h";
    }
	
	// Update is called once per frame
	//void Update () {
 //       if(mov.motorforce<0)
 //       {
 //           reversa.SetActive(true);
 //       }
 //       else if(mov.motorforce>=0)
 //       {
 //           reversa.SetActive(false);
 //       }
 //       actualizarVelocidad();
 //   }
}
