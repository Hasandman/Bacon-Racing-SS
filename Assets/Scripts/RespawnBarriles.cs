using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBarriles : MonoBehaviour {

    public GameObject barril1;
    public GameObject barril2;
    public GameObject barril3;
    public GameObject barril4;

  
    public void Start()
    {

        RespwnBarr();

    }


    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(RespawnDestrucBarr());
     
    }

    IEnumerator RespawnDestrucBarr()
        {
        Debug.Log("Entraste");
        EliminarBarr();
        yield return new WaitForSeconds(5);
        RespwnBarr();
       
    }
   

    public void RespwnBarr()
    {
        Instantiate(barril1, barril1.transform.position, barril1.transform.rotation);
        Instantiate(barril2, barril2.transform.position, barril2.transform.rotation);
        Instantiate(barril3, barril3.transform.position, barril3.transform.rotation);
        Instantiate(barril4, barril4.transform.position, barril4.transform.rotation);
    }

    public void EliminarBarr()
    {
        Object.Destroy(barril1);
        Object.Destroy(barril2);
        Object.Destroy(barril3);
        Object.Destroy(barril4);
    }

    public void RespawnItems1()
    {
        Debug.Log("respwn1");
        StartCoroutine(nuevoRespawnItem1());
    }

    public void RespawnItems2()
    {
        StartCoroutine(nuevoRespawnItem2());
    }


    public void RespawnItems3()
    {
        StartCoroutine(nuevoRespawnItem3());
    }


    public void RespawnItems4()
    {
        StartCoroutine(nuevoRespawnItem4());
    }


    IEnumerator nuevoRespawnItem1()
    {
      
        yield return new WaitForSeconds(1);
        Instantiate(barril1, barril1.transform.position, barril1.transform.rotation);
       
    }
    IEnumerator nuevoRespawnItem2()
    {

        yield return new WaitForSeconds(1);
        Instantiate(barril2, barril2.transform.position, barril1.transform.rotation);
    }
    IEnumerator nuevoRespawnItem3()
    {

        yield return new WaitForSeconds(1);
        Instantiate(barril3, barril3.transform.position, barril1.transform.rotation);
    }
    IEnumerator nuevoRespawnItem4()
    {

        yield return new WaitForSeconds(1);
        Instantiate(barril4, barril4.transform.position, barril1.transform.rotation);
    }

}
