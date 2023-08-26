using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaTurismo : Prueba
{

    void Start()
    {
        //CargarPrueba();
    }




    public override void CargarPrueba()
    {
        ascensor = (GameObject)Resources.Load("Escenarios/Esc_turismo");

        switch (Random.Range(0,3))
        {
            case 0:
                imagen = (GameObject)Resources.Load("Imagenes/img_eiffel");
                break;
            case 1:
                imagen = (GameObject)Resources.Load("Imagenes/img_coliseo");
                break;
            case 2:
                imagen = (GameObject)Resources.Load("Imagenes/img_libertad");
                break;
            default:
                break;
        }

        
        MoverAscensores();
    }

    public override void PrepararDatos()
    {
        tipo = TipoPrueba.Turismo;


        switch (Random.Range(0, 3))
        {
            case 0:
                pathImagen = "Imagenes/img_eiffel";
                break;
            case 1:
                pathImagen = "Imagenes/img_coliseo";
                break;
            case 2:
                pathImagen = "Imagenes/img_libertad";
                break;
            default:
                break;
        }

    }

}
