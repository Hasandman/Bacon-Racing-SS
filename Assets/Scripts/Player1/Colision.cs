using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour {


    public GameObject player1;
    public Movimiento mov;
    public GameObject check;
    public GameObject check2;
    public GameObject check3;
    public GameObject check4;
    public static Vector3 nuevaPosicion;
    public static Quaternion nuevaRotacion;


    public void OnTriggerEnter(Collider other)
    {
       
        switch (other.tag)
        {
            
            case "chp11":
                nuevaPosicion = check.transform.position;
                nuevaRotacion = check.transform.rotation;
                GameControl.saltos1 = 0;
                break;
            case "chp12":
                nuevaPosicion = check2.transform.position;
                nuevaRotacion = check2.transform.rotation;
                GameControl.saltos1 = 0;
                break;
            case "chp13":
                nuevaPosicion = check3.transform.position;
                nuevaRotacion = check3.transform.rotation;
                GameControl.saltos1 = 0;
                break;
            case "chp14":
                nuevaPosicion = check4.transform.position;
                nuevaRotacion = check4.transform.rotation;
                GameControl.saltos1 = 0;
                break;
            case "lap1":
                if(Vueltas.verificador11==true)
                {
                    Vueltas.checkpointP1 += 1;
                    Debug.Log(Vueltas.checkpointP1);
                }
                Vueltas.verificador11 = false;
                break;
            case "lap2":
                if (Vueltas.verificador12 == true)
                {
                    Vueltas.checkpointP1 += 1;
                    Debug.Log(Vueltas.checkpointP1);
                }
                Vueltas.verificador12 = false;

                break;
            case "lap3":
                if (Vueltas.verificador13 == true)
                {
                    Vueltas.checkpointP1 += 1;
                    Debug.Log(Vueltas.checkpointP1);
                }
                Vueltas.verificador13 = false;

                break;
            case "lap4":
                if (Vueltas.verificador14 == true)
                {
                    Vueltas.checkpointP1 += 1;
                    Debug.Log(Vueltas.checkpointP1);
                }
                Vueltas.verificador14 = false;

                break;
        }
    }


public void Start()
    {

        

      nuevaPosicion = player1.transform.position;

        nuevaRotacion = player1.transform.rotation;

    }

    public void Update()
    {
      


        if (gameObject.transform.position.y < -1.00f )
        {


            player1.transform.position = nuevaPosicion;
            player1.transform.rotation = nuevaRotacion;

        }

    }

}
