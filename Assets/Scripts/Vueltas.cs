using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Vueltas : MonoBehaviour {

   public static int checkpointP1 = 0;
    public static int checkpointP2 = 0;
  
    public GameObject PosicionJugador1_1;
    public GameObject PosicionJugador1_2;
    public GameObject PosicionJugador2_1;
    public GameObject PosicionJugador2_2;

    public GameObject ganadorP1;
    public GameObject ganadorP2;

   
    //public MostrarVueltas mV1j;
    //public MostrarVueltas1 mV2j;

    public static bool verificador11 = true;
    public static bool verificador12 = true;
    public static bool verificador13 = true;
    public static bool verificador14 = true;

    public static bool verificador21 = true;
    public static bool verificador22 = true;
    public static bool verificador23 = true;
    public static bool verificador24 = true;


    private bool beingHandled = false;

    public void Start()
    {
        ganadorP1.SetActive(false);
        ganadorP2.SetActive(false);

        GanandoJugador1();
    }

    public void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "Player1":


               if (checkpointP1 <= 4)
               {
                    
                

                    if (checkpointP1 > 4)
                    {
                    verificador11 = true;
                    verificador12 = true;
                    verificador13 = true;
                    verificador14 = true;
                    GameControl.vueltasP1 += 1;
                    checkpointP1 = 0;
                   

                    Debug.Log("vuelta");
  
                    }
               }
           
                break;
            case "Player2":
                if (checkpointP2 <= 4)
                {
                 
                    Movimiento1.jumpping = false;

                    if (checkpointP2 == 4)
                    {

                        GameControl.vueltasP2 += 1;
                        verificador21 = true;
                        verificador22 = true;
                        verificador23 = true;
                        verificador24 = true;
                        checkpointP2 = 0;

                    }
                }
             
                break;
        }

    }

    public void Update()
    {
        PosicionJugadores();

        Ganador();
       
    }
    

    //Metodos aplicados---------------------------------------------
 
    private IEnumerator HandleIt()
    {
        beingHandled = true;
        // process pre-yield
        yield return new WaitForSeconds(4.0f);
        
        SceneManager.LoadScene(GameControl.cargarPista);
        // process post-yield
        beingHandled = false;
    }

    public void Reset()
    {
        GameControl.vueltasP1 = 0;
        GameControl.vueltasP2 = 0;
        checkpointP1 = 0;
        checkpointP2 = 0;
    

    }

    public void PosicionJugadores()
    {
        if (checkpointP1 > checkpointP2 || GameControl.vueltasP1 > GameControl.vueltasP2)
        {
            GanandoJugador1();

        }
        else
        {
            GanandoJugador2();
        }
        
    }

    public void Ganador()
    {
        if (GameControl.vueltasP1 > GameControl.vueltasTotal)
        {
           
            ganadorP1.SetActive(true);

            Debug.Log("Gana p1");

            GameControl.Jugar = false;

            if (GameControl.cargarPista == "MenuPrincipal")
            {
                GameControl.cargarPista = "Nivel01";

            }
            else if (GameControl.cargarPista == "Nivel01")
            {
                GameControl.cargarPista = "Nivel02";
                
            }
            else if (GameControl.cargarPista == "Nivel02")
            {
                GameControl.cargarPista = "MenuPrincipal";

            }

            if ( /*some case  */ !beingHandled)
            {
                StartCoroutine(HandleIt());
            }
            Reset();


           


        }
        else if (GameControl.vueltasP2 > GameControl.vueltasTotal)
        {
           
            Debug.Log("Gana p2");

            ganadorP2.SetActive(true);

            GameControl.Jugar = false;

            if (GameControl.cargarPista == "MenuPrincipal")
            {
                GameControl.cargarPista = "Nivel01";

            }
            else if (GameControl.cargarPista == "Nivel01")
            {
                GameControl.cargarPista = "Nivel02";

            }
            else if (GameControl.cargarPista == "Nivel02")
            {
                GameControl.cargarPista = "MenuPrincipal";
            }

                if ( /*some case  */ !beingHandled)
            {
                StartCoroutine(HandleIt());
            }

            Reset();

        }
    }



    public void GanandoJugador1()
    {
        PosicionJugador1_1.SetActive(true);
        PosicionJugador1_2.SetActive(false);

        PosicionJugador2_1.SetActive(false);
        PosicionJugador2_2.SetActive(true);
    }

    public void GanandoJugador2()
    {
        PosicionJugador1_1.SetActive(false);
        PosicionJugador1_2.SetActive(true);

        PosicionJugador2_1.SetActive(true);
        PosicionJugador2_2.SetActive(false);
    }

}

