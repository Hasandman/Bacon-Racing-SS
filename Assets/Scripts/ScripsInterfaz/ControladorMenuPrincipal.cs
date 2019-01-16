using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenuPrincipal : MonoBehaviour 
{

    public GameObject menuPrincipal;
    public GameObject instrucciones;
    public GameObject creditos;

    public void Awake()
    {
        GameControl.cargarPista = "Nivel01";
    }

    public void Start()
	{

        Regresar();
	}

	public void Jugar()
	{
		SceneManager.LoadScene("Seleccion", LoadSceneMode.Single);
	}

    public void pantallaJugar()
    {
        instrucciones.SetActive(false);
        menuPrincipal.SetActive(true);
        creditos.SetActive(false);
    }

	public void Creditos()
	{
		creditos.SetActive(true);
        menuPrincipal.SetActive(false);
        instrucciones.SetActive(false);
    }
	
	public void Instrucciones()
	{
		instrucciones.SetActive(true);
		menuPrincipal.SetActive(false);
		creditos.SetActive(false);

	}

    public void Regresar()
    {
        menuPrincipal.SetActive(false);
        instrucciones.SetActive(false);
        creditos.SetActive(false);
    }
	public void Salir()
	{
		Application.Quit();
	}
}
