using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlIconosItems : MonoBehaviour {

    public GameObject itemVelocidad;
    public GameObject itemManchaPantalla;
    public GameObject itemEscudo;
    public GameObject itemDejarBotella;
    public GameObject itemLanzarBotella;

    public GameObject itemVelocidad2;
    public GameObject itemManchaPantalla2;
    public GameObject itemEscudo2;
    public GameObject itemDejarBotella2;
    public GameObject itemLanzarBotella2;


    private void Start()
    {
        desactivarIconoItems();
        desactivarIconoItems2();
    }

    private void Update()
    {
        if (Item.itemsP1)
        {
            ObtenerIconoItem1();

        }
        else
        {
            desactivarIconoItems();
        }


       if (Item.itemsP2)
        {
            ObtenerIconoItem2();
        }else
        {
            desactivarIconoItems2();
        }
    }
  
      


  

    public void ObtenerIconoItem1()
    {
       
        switch (Item.randomP1)
        {
            case 1:
        
                activarIconoDejarBotella();
            

                break;
            case 2:
             
                activarIconoEscudo();
             
                break;
            case 3:
             
                activarIconoLanzarBotella();
           
                break;
            case 4:
              
                activarIconoMancha();

               
                break;
            case 5:
            
                activarIconoVelocidad();
             
                break;

        }
    
    }


    public void ObtenerIconoItem2()
    {

        switch (Item.randomP2)
        {
            case 1:

                activarIconoDejarBotella2();


                break;
            case 2:

                activarIconoEscudo2();

                break;
            case 3:

                activarIconoLanzarBotella2();

                break;
            case 4:

                activarIconoMancha2();


                break;
            case 5:

                activarIconoVelocidad2();

                break;

        }

    }




    public void desactivarIconoItems()
    {
       
        itemVelocidad.SetActive(false);
        itemManchaPantalla.SetActive(false);
        itemEscudo.SetActive(false);
        itemDejarBotella.SetActive(false);
        itemLanzarBotella.SetActive(false);
    }

    void activarIconoVelocidad()
    {
  
        itemVelocidad.SetActive(true);
        itemManchaPantalla.SetActive(false);
        itemEscudo.SetActive(false);
        itemDejarBotella.SetActive(false);
        itemLanzarBotella.SetActive(false);
    }

    void activarIconoMancha()
    {
        
        itemVelocidad.SetActive(false);
        itemManchaPantalla.SetActive(true);
        itemEscudo.SetActive(false);
        itemDejarBotella.SetActive(false);
        itemLanzarBotella.SetActive(false);
    }

    void activarIconoEscudo()
    {
     
        itemVelocidad.SetActive(false);
        itemManchaPantalla.SetActive(false);
        itemEscudo.SetActive(true);
        itemDejarBotella.SetActive(false);
        itemLanzarBotella.SetActive(false);
    }

    void activarIconoDejarBotella()
    {
   

        itemVelocidad.SetActive(false);
        itemManchaPantalla.SetActive(false);
        itemEscudo.SetActive(false);
        itemDejarBotella.SetActive(true);
        itemLanzarBotella.SetActive(false);
    }

    void activarIconoLanzarBotella()
    {
   
        itemVelocidad.SetActive(false);
        itemManchaPantalla.SetActive(false);
        itemEscudo.SetActive(false);
        itemDejarBotella.SetActive(false);
        itemLanzarBotella.SetActive(true);
    }



    //-------------------------------------------------P2

    public void desactivarIconoItems2()
    {
    
        itemVelocidad2.SetActive(false);
        itemManchaPantalla2.SetActive(false);
        itemEscudo2.SetActive(false);
        itemDejarBotella2.SetActive(false);
        itemLanzarBotella2.SetActive(false);
    }

    void activarIconoVelocidad2()
    {
      
        itemVelocidad2.SetActive(true);
        itemManchaPantalla2.SetActive(false);
        itemEscudo2.SetActive(false);
        itemDejarBotella2.SetActive(false);
        itemLanzarBotella2.SetActive(false);
    }

    void activarIconoMancha2()
    {
     
        itemVelocidad2.SetActive(false);
        itemManchaPantalla2.SetActive(true);
        itemEscudo2.SetActive(false);
        itemDejarBotella2.SetActive(false);
        itemLanzarBotella2.SetActive(false);
    }

    void activarIconoEscudo2()
    { 
        itemVelocidad2.SetActive(false);
        itemManchaPantalla2.SetActive(false);
        itemEscudo2.SetActive(true);
        itemDejarBotella2.SetActive(false);
        itemLanzarBotella2.SetActive(false);
    }

    void activarIconoDejarBotella2()
    {
        

        itemVelocidad2.SetActive(false);
        itemManchaPantalla2.SetActive(false);
        itemEscudo2.SetActive(false);
        itemDejarBotella2.SetActive(true);
        itemLanzarBotella2.SetActive(false);
    }

    void activarIconoLanzarBotella2()
    {
        
        itemVelocidad2.SetActive(false);
        itemManchaPantalla2.SetActive(false);
        itemEscudo2.SetActive(false);
        itemDejarBotella2.SetActive(false);
        itemLanzarBotella2.SetActive(true);
    }

}
