using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item3 : MonoBehaviour {

    float velocidad = 10f;
 

 
	// Update is called once per frame
	void Update () {
      transform.Translate(0, 0, velocidad * Time.deltaTime);
        //transform.Rotate(1, 1, 1);
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player2"))
        {
          
            StartCoroutine(TiempoItem3());
            Destroy(gameObject);


        }
    }


    IEnumerator TiempoItem3()
    {

        GameControl.velocidad2 = -5f;
     
        yield return new WaitForSeconds(5);


        GameControl.velocidad2 = 1f;



    }
}
