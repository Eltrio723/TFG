using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaPosiciones : Prueba
{
 

    public override void CargarPrueba()
    {
        ascensor = null; 

        switch (Random.Range(0, 3))
        {
            case 0:
                pathTriggers = "Assets/Resources/Triggers/posiciones1.json";
                break;
            case 1:
                pathTriggers = "Assets/Resources/Triggers/posiciones2.json";
                break;
            case 2:
                pathTriggers = "Assets/Resources/Triggers/posiciones3.json";
                break;
            default:
                break;
        }


        MoverAscensores();
    }
}
