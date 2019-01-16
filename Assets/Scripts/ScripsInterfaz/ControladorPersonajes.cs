using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControladorPersonajes : MonoBehaviour
 {
    //crear clase estatica de la misma para hacerla inmortal
    public static ControladorPersonajes controladorPersonajes;

    //

   

   
    public bool p1Tequila;
    public bool p2Tequila;

    public bool p1Japones;
    public bool p2Japones;

    public bool Pista1;

    public GameObject imagenPista1;

    public GameObject imagenTequilaP1;
    public GameObject imagenJaponesP1;

    public GameObject imagenTequilaP2;
    public GameObject imagenJaponesP2;



    public void Start()
 	{
        //Asignar la instancia de la clase inmortal a this
        controladorPersonajes = this;

        //Hacer inmortal la clase y poder usar los valores en cualquier escena
        GameObject.DontDestroyOnLoad(this.gameObject);

        //

        Pista1 = false;

        p1Japones = false;
        p1Tequila = true;

        p2Japones = false;
        p2Tequila = true;

        imagenPista1.SetActive(true);

        imagenTequilaP1.SetActive(true);
        imagenJaponesP1.SetActive(false);
        imagenTequilaP2.SetActive(true);
        imagenJaponesP2.SetActive(false);

        PanelSeleccionPersonaje.gameObject.SetActive(true);
 		PanelSeleccionCopa.gameObject.SetActive(false);
 	}

	public RectTransform PanelSeleccionPersonaje;
	public RectTransform PanelSeleccionCopa;

	public void Regresar()
	{

		SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
	}
	public void Siguiente()
	{

		PanelSeleccionCopa.gameObject.SetActive(true);
		PanelSeleccionPersonaje.gameObject.SetActive(false);
	}

	public void RegresarAnterior()
	{
		PanelSeleccionPersonaje.gameObject.SetActive(true);
		PanelSeleccionCopa.gameObject.SetActive(false);

	}
	public void SiguienteComenzar()
	{
		SceneManager.LoadScene("PantallaCarga", LoadSceneMode.Single);
	}


    //Botones de seleccion de personaje

    public void siguienteP1()
    {
        //p1Japones = true;
        //p1Tequila = false;

        imagenTequilaP1.SetActive(false);
        imagenJaponesP1.SetActive(true);

    }

    public void siguienteP2()
    {
        //p2Japones = true;
        //p2Tequila = false;

        imagenTequilaP2.SetActive(false);
        imagenJaponesP2.SetActive(true);

    }

    public void anteriorP1()
    {
        //p1Japones = false;
        //p1Tequila = true;

        imagenTequilaP1.SetActive(true);
        imagenJaponesP1.SetActive(false);

    }

    public void anteriorP2()
    {
    //    p2Japones = false;
    //    p2Tequila = true;

        imagenTequilaP2.SetActive(true);
        imagenJaponesP2.SetActive(false);

    }

    public void ElegirPista1()
    {
        Pista1 = true;
    }

}
