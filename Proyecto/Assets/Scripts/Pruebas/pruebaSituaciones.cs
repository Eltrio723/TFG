using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaSituaciones : Prueba
{
    void Start()
    {
        //CargarPrueba();
    }





    public override void CargarPrueba()
    {
        ascensor = null; //(GameObject)Resources.Load("Escenarios/Esc_vacio");

        switch (Random.Range(0, 3))
        {
            case 0:
                imagen = (GameObject)Resources.Load("Imagenes/img_medico");
                break;
            case 1:
                imagen = (GameObject)Resources.Load("Imagenes/img_cole");
                break;
            case 2:
                imagen = (GameObject)Resources.Load("Imagenes/img_feria");
                break;
            default:
                break;
        }


        MoverAscensores();
    }
}
