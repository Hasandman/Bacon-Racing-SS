using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision1 : MonoBehaviour
{

    public GameObject player2;
    public Movimiento1 mov2;
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

            case "chp21":
                nuevaPosicion = check.transform.position;
                nuevaRotacion = check.transform.rotation;
                GameControl.saltos2 = 0;
                break;
            case "chp22":
                nuevaPosicion = check2.transform.position;
                nuevaRotacion = check2.transform.rotation;
                GameControl.saltos2 = 0;
                break;
            case "chp23":
                nuevaPosicion = check3.transform.position;
                nuevaRotacion = check3.transform.rotation;
                GameControl.saltos2 = 0;
                break;
            case "chp24":
                nuevaPosicion = check4.transform.position;
                nuevaRotacion = check4.transform.rotation;
                GameControl.saltos2 = 0;
                break;
            case "lap1":
                if (Vueltas.verificador21 == true)
                {
                    Vueltas.checkpointP2 += 1;
                }
                Vueltas.verificador21 = false;
                break;
            case "lap2":
                if (Vueltas.verificador22 == true)
                {
                    Vueltas.checkpointP2 += 1;
                }
                Vueltas.verificador22 = false;

                break;
            case "lap3":
                if (Vueltas.verificador23 == true)
                {
                    Vueltas.checkpointP2 += 1;
                }
                Vueltas.verificador23 = false;

                break;
            case "lap4":
                if (Vueltas.verificador24 == true)
                {
                    Vueltas.checkpointP2 += 1;
                }
                Vueltas.verificador24 = false;

                break;

        }
    }


    public void Start()
    {
   

        nuevaPosicion = player2.transform.position;

        nuevaRotacion = player2.transform.rotation;

    }


    public void Update()
    {

        if (player2.transform.position.y < -1.00f)
        {

            player2.transform.position = nuevaPosicion;
            player2.transform.rotation = nuevaRotacion;

        }

    }

}