using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaparecerBarril : MonoBehaviour {

    RespawnBarriles barriles;
    public GameObject BarrilConte;
    public GameObject Barril;


    private void OnTriggerEnter(Collider other)
    {
        barriles.EliminarBarr();
        barriles.RespwnBarr();
    }

}
