using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public static int randomP1;
    public static int randomP2;
    public static bool itemCargado1 = false;
    public static bool itemCargado2 = false;
    public static int numItem1;
    public static int numItem2;

    public static bool itemsP1=false;
    public static bool itemsP2=false;

    public GameObject efectoBarril;
    public GameObject Barril;
    public Light luz;


    public void OnTriggerEnter(Collider other)
    {
        Destroy(luz);
        if (other.CompareTag("Player1"))
        {
            itemsP1 = true;
            StartCoroutine(RecogerItem(other));
            ObtenerItem();
          //  ObtenerItem1(randomP1);

        }
        else if (other.CompareTag("Player2"))
        {
            itemsP2 = true;
            StartCoroutine(RecogerItem(other));
            ObtenerItem2();

        }


    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(3, 12, 0);

    }

    IEnumerator RecogerItem(Collider player)
    {

        //Efecto al al tomarlo
        Instantiate(efectoBarril, transform.position, transform.rotation);

        //Seguntos antes de destruirse
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;


        yield return new WaitForSeconds(3);

        //Destruir Item

        Destroy(gameObject);



    }

    public void ObtenerItem()
    {
        randomP1 = (Random.Range(1, 6));

        switch (randomP1)
        {
            case 1:
              

                itemCargado1 = true;

                break;
            case 2:

                itemCargado1 = true;
                break;
            case 3:
          
                itemCargado1 = true;
                break;
            case 4:
            

                itemCargado1 = true;
                break;
            case 5:
        
                itemCargado1 = true;
                break;

        }

        numItem1 = randomP1;

    }


    public int ObtenerItem1(int _randomP1)
    {
        _randomP1 = (Random.Range(1, 6));

        switch (_randomP1)
        {
            case 1:
                Debug.Log("Item1");
  
                itemCargado1 = true;

                break;
            case 2:
                Debug.Log("Item2");
                itemCargado1 = true;
                break;
            case 3:
                Debug.Log("Item3");
                itemCargado1 = true;
                break;
            case 4:
                Debug.Log("Item4");

                itemCargado1 = true;
                break;
            case 5:
                Debug.Log("Item5");
                itemCargado1 = true;
                break;

        }

        return _randomP1;
    }

    public void ObtenerItem2()
    {
        randomP2 = (Random.Range(1, 6));

        switch (randomP2)
        {
            case 1:
                Debug.Log("Item1");

                itemCargado2 = true;

                break;
            case 2:
                Debug.Log("Item2");
                itemCargado2 = true;
                break;
            case 3:
                Debug.Log("Item3");
                itemCargado2 = true;
                break;
            case 4:
                Debug.Log("Item4");

                itemCargado2 = true;
                break;
            case 5:
                Debug.Log("Item5");
                itemCargado2 = true;
                break;

        }

        numItem2 = randomP2;

    }





}
