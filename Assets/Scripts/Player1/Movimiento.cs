using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movimiento : MonoBehaviour {

    public GameObject Anim_Idle;
    public GameObject Anim_Correr;

    public GameObject player1Items;
    public Rigidbody player1;
    ControlIconosItems iconos;

    Animator animar;
    //public RespawnBarriles barril;
   
   
    public float jump=5.0f;

    

    public GameObject item1;
    public GameObject item3;

    public GameObject item4;


    private void Start()
    {
        animar = GetComponentInChildren<Animator>();

        Anim_Correr.SetActive(false);
        animar.Play("Cerdo_Idle");

        item4.SetActive(false);

       
    }

    void FixedUpdate()
    {

        if (GameControl.Jugar && GameControl.pausa==false)
        {
           
            if (GameControl.velocidad1 < GameControl.maxSpeed1 && (Input.GetAxis("Vertical") == 1 || Input.GetAxis("Vertical") == -1))
            {
                Anim_Correr.SetActive(true);
                Anim_Idle.SetActive(false);
                animar.Play("Anim_correr");
              

                GameControl.velocidad1 += Time.deltaTime * 4;

                if (GameControl.velocidad1 > GameControl.maxSpeed1)
                {
                    GameControl.velocidad1 = GameControl.maxSpeed1;

              
                }
            }else
            {

                GameControl.velocidad1 -= Time.deltaTime *3;

                if (GameControl.velocidad1 < GameControl.minSpeed1)
                {
                    Anim_Correr.SetActive(false);
                    Anim_Idle.SetActive(true);
                    animar.Play("Cerdo_Idle");
                    GameControl.velocidad1 = GameControl.minSpeed1;
                    
                }
            }

            player1.transform.Translate(0,0, Input.GetAxis("Vertical") * GameControl.velocidad1 * Time.deltaTime);

            player1.transform.Rotate(0, Input.GetAxis("Horizontal") * GameControl.angulo, 0);


            if (Input.GetButtonDown("Jump") && GameControl.saltos1 <= GameControl.saltosMaximos1)
            {
                GameControl.saltos1+=1;

                player1.velocity = new Vector3(0, jump, 0);
                player1.angularVelocity = Vector3.zero;

            }

            else if (Input.GetKey(KeyCode.M) && Item.itemCargado1==true)
            {
      
                 items();
                Item.itemCargado1 = false;
                Item.itemsP1 = false;
            
            
            }

        }

    }

   
    public void items()
    {
        switch(Item.numItem1)
        {
            case 1:
               
                PoderItem1();
    
                break;
            case 2:
              
                PoderItem2();
                break;
            case 3:
             
                PoderItem3();
                break;
            case 4:
             
                PoderItem4();

                break;
            case 5:
               
                PoderItem5();
                break;
  
        }
    }

    public void PoderItem1()
    {
   
        Instantiate(item1, transform.position, transform.rotation);

    }

   public void  PoderItem2()
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
        GameControl.velocidad1 = 8.0f;
        GameControl.maxSpeed1 = 8.0f;
        yield return new WaitForSeconds(5);
        GameControl.velocidad1 = 1.0f;
        GameControl.maxSpeed1 = 5.0f;
    }


  
}


