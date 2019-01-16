using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RptacionCamara : MonoBehaviour {

    //Rotacion X

    float sensibilidad = 4;
    float anguloMin = 454.0f;
    float anguloMax = 630.0f;
    float xRotacion;
    float camRot;
    float limiteCamara;

    //Rotacion Y

    float anguloMinY = 5.0f;
    float anguloMaxY = 90.0f;
    float yRotacion;
    float camRotY;
    float limiteCamaraY;

    //Camara
    public Camera mainCamara;


    private void Update()
    {
        //RotacionX
        xRotacion = Input.GetAxis("Horizontal");
        camRot = xRotacion * sensibilidad;

        limiteCamara += camRot;
        limiteCamara = Mathf.Clamp(limiteCamara, anguloMin, anguloMax);

        //RotacionY

        yRotacion = Input.GetAxis("Vertical");
        camRotY = yRotacion * sensibilidad;

        limiteCamaraY -= camRotY;
        limiteCamaraY = Mathf.Clamp(limiteCamaraY, anguloMinY, anguloMaxY);

        //Resultado
        mainCamara.transform.localEulerAngles = new Vector3(limiteCamaraY, limiteCamara, 0);

    }
}
