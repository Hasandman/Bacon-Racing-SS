using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RaycastMenu : MonoBehaviour {

    public float rayLongitud;
    public ControladorMenuPrincipal menu;


    private void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue);

        if(Input.GetMouseButton(0))
        {
            if(Physics.Raycast(ray,out hit)==true && hit.transform.name== "RayCastJugar")
            {
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);

                menu.pantallaJugar();
            }else if(Physics.Raycast(ray, out hit) == true && hit.transform.name == "RayCastCreditos")
            {
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.yellow);
     
                menu.Creditos();
            }else if(Physics.Raycast(ray, out hit) == true && hit.transform.name == "RayCastInstrucciones")
            {
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.green);

                menu.Instrucciones();
            }
        }
    }

}
