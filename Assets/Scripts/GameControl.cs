using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameControl : MonoBehaviour {

    public GameObject Nido;
    public GameObject TequilaP1;
    public GameObject TequilaP2;

    public GameObject JaponesP1;
    public GameObject JaponesP2;

    private Movimiento movimiento;
    private Movimiento1 movimiento1;

    private Colision colision;
    private Colision1 colision1;

    public static float maxSpeed1 = 5.0f;
    public static float minSpeed1 = 1.0f;

    public static float maxSpeed2 = 5.0f;
    public static float minSpeed2 = 1.0f;

    public static float velocidad1 = 1f;
    public static float velocidad2 = 1f;

    public static float angulo = 1.5f;
    public static bool Jugar = false;
    public static float comienzoTiempo;
    public static float ReinicioNivel = 4f;
    public static int vueltasP1;
    public static int vueltasP2;
    public static int vueltasTotal=3;
    public static bool pausa = false;
    public static int saltosMaximos1 = 4;
    public static int saltosMaximos2 = 4;

    public static int saltos1 = 0;
    public static int saltos2 = 0;

    public static string cargarPista="Nivel01";


    public void Start()
    {
        Nido.SetActive(false);

        InstanciarPlayer();

        comienzoTiempo = 4f;
        vueltasP1 = 0;
        vueltasP2 = 0;
        vueltasTotal = 3;

    }


    private void Update()
    {
       

        Inputs();
    }

    public void Reset()
    {
        vueltasP1 = 0;
        vueltasP2 = 0;
        Vueltas.checkpointP1 = 0;
        Vueltas.checkpointP2 = 0;
        comienzoTiempo = 4f;
        Jugar = false;
    }

    public void InstanciarPlayer()
    {

        if (ControladorPersonajes.controladorPersonajes.p1Japones == true && ControladorPersonajes.controladorPersonajes.p2Japones == true)
        {
            Destroy(TequilaP1);
            Destroy(TequilaP2);
    


        }
        else if (ControladorPersonajes.controladorPersonajes.p1Tequila == true && ControladorPersonajes.controladorPersonajes.p2Tequila == true)
        {
            Destroy(JaponesP1);
            Destroy(JaponesP2);

 

        }
        else if (ControladorPersonajes.controladorPersonajes.p1Tequila == true && ControladorPersonajes.controladorPersonajes.p2Japones == true)
        {
            Destroy(JaponesP1);
            Destroy(TequilaP2);

        }
        else if (ControladorPersonajes.controladorPersonajes.p1Japones == true && ControladorPersonajes.controladorPersonajes.p2Tequila == true)
        {

            Destroy(TequilaP1);
            Destroy(JaponesP2);


        }
    }

    public void Inputs()
    {
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene(GameControl.cargarPista);
            Reset();
        }
        else if (Input.GetKey(KeyCode.P))
        {
            if (pausa == false)
            {
                pausa = true;
            }
            else if (pausa == true)
            {
                pausa = false;
            }
        }
        else if (Input.GetKey(KeyCode.N))
             {
            
             Nido.SetActive(true);
            }
    }
 }





