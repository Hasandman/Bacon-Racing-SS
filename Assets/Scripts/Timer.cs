using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

   
    public Text temporizador;

    // Use this for initialization
    private void Awake()
    {
        GameControl.comienzoTiempo = 4f;
        GameControl.Jugar = false;
      
    }


    void Start () {
      
        temporizador.text = (" " + GameControl.comienzoTiempo.ToString("f0"));
    }
	
	// Update is called once per frame
	void Update () {

        if(GameControl.Jugar==false)
        {
            GameControl.comienzoTiempo -= Time.deltaTime;
            temporizador.text = (" " + GameControl.comienzoTiempo.ToString("f0"));
            if (GameControl.comienzoTiempo <1)
            {
                GameControl.comienzoTiempo = 0;
                GameControl.Jugar = true;
                temporizador.enabled = false;
            }
        }
       
	}
}
