using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour {

   public bool Pause(bool _pausa)
    {

        if(_pausa == false)
        {
            _pausa = true;
        }
        else if(_pausa == true)
        {
            _pausa = false;
        }

        return _pausa;

    }
}
