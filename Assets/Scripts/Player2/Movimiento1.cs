using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movimiento1 : MonoBehaviour {

 
    public Rigidbody player2;
    public float jump=5.0f;
    public static bool jumpping=false;
    ControlIconosItems iconos2;



    public GameObject item1;
    public GameObject item3;

    public GameObject item4;

    private void Start()
    {
        item4.SetActive(false);


    }

    void FixedUpdate()
    {
        
        if(GameControl.Jugar && GameControl.pausa==false)
        {

            
           

            if (GameControl.velocidad2 < GameControl.maxSpeed2 && (Input.GetAxis("Vertical2") == 1 || Input.GetAxis("Vertical2") == -1))
            {
                GameControl.velocidad2 += Time.deltaTime * 4;

                if (GameControl.velocidad2 > GameControl.maxSpeed2)
                {
                    GameControl.velocidad2 = GameControl.maxSpeed2;
                }
            }
            else
            {
                GameControl.velocidad2 -= Time.deltaTime * 3;

                if (GameControl.velocidad2 < GameControl.minSpeed2)
                {
                    GameControl.velocidad2 = GameControl.minSpeed2;

                }
            }

            player2.transform.Translate(0, 0, Input.GetAxis("Vertical2") * GameControl.velocidad2 * Time.deltaTime);

            player2.transform.Rotate(0, Input.GetAxis("Horizontal2") * GameControl.angulo , 0);



           

            if (Input.GetButtonDown("Jump2") )
            {
                GameControl.saltos2 += 1;

                player2.velocity = new Vector3(0, jump, 0);
                player2.angularVelocity = Vector3.zero;
          

            }

            else if (Input.GetKey(KeyCode.E) && Item.itemCargado2 == true)
            {

                items();
                Item.itemCargado2 = false;
                Item.itemsP2 = false;

            }

        }

    }


    public void items()
    {
        switch (Item.numItem2)
        {
            case 1:
             
                PoderItem1();

                break;
            case 2:
              
                PoderItem1();
                break;
            case 3:
              
                PoderItem1();
                break;
            case 4:
               
                PoderItem1();

                break;
            case 5:
               
                PoderItem1();
                break;

        }
    }

    public void PoderItem1()
    {

        Instantiate(item1, transform.position, transform.rotation);
    }

    public void PoderItem2()
    {


        StartCoroutine(TiempoItem2());

    }

    IEnumerator TiempoItem2()
    {

        transform.localScale = new Vector3(.2f, 0.09224271f, .2f);

        yield return new WaitForSeconds(5);

        transform.localScale = new Vector3(0.09224271f, 0.09224271f, 0.09224271f);

    }


    public void PoderItem3()
    {
        StartCoroutine(TiempoItem3());
    }

    IEnumerator TiempoItem3()
    {
        Instantiate(item3, transform.position, transform.rotation);

        yield return new WaitForSeconds(5);



    }

    public void PoderItem4()
    {
        StartCoroutine(TiempoItem4());
    }

    IEnumerator TiempoItem4()
    {
        item4.SetActive(true);
        yield return new WaitForSeconds(5);
        item4.SetActive(false);



    }

    public void PoderItem5()
    {
        StartCoroutine(TiempoItem5());
    }

    IEnumerator TiempoItem5()
    {
        GameControl.velocidad2 = 8.0f;
        GameControl.maxSpeed2 = 8.0f;
        yield return new WaitForSeconds(5);
        GameControl.velocidad2 = 1.0f;
        GameControl.maxSpeed2 = 5.0f;



    }

   
   
}

