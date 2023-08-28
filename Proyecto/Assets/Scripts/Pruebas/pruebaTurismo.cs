using System.Collections.Generic;
using UnityEngine;

public class PruebaTurismo : Prueba
{

    void Start()
    {
        //CargarPrueba();
    }




    //public override void CargarPrueba()
    //{
    //    ascensor = (GameObject)Resources.Load("Escenarios/Esc_turismo");

    //    switch (Random.Range(0,3))
    //    {
    //        case 0:
    //            imagen = (GameObject)Resources.Load("Imagenes/img_eiffel");
    //            break;
    //        case 1:
    //            imagen = (GameObject)Resources.Load("Imagenes/img_coliseo");
    //            break;
    //        case 2:
    //            imagen = (GameObject)Resources.Load("Imagenes/img_libertad");
    //            break;
    //        default:
    //            break;
    //    }


    //    MoverAscensores();
    //}

    public override void PrepararDatos()
    {
        tipo = TipoPrueba.Turismo;

        listaRespuestas = new List<string>
        {
            "Torre Eiffel (París)",
            "Coliseo (Roma)",
            "Estatua Libertad (Nueva York)",
            "Alhambra (Granada)"
        };


        switch (Random.Range(0, 3))
        {
            case 0:
                pathImagen = "Imagenes/img_eiffel";
                respuestaCorrecta = 1;
                break;
            case 1:
                pathImagen = "Imagenes/img_coliseo";
                respuestaCorrecta = 2;
                break;
            case 2:
                pathImagen = "Imagenes/img_libertad";
                respuestaCorrecta = 3;
                break;
            default:
                break;
        }

    }
    public override bool CheckCorrecto()
    {
        return false;
    }

}
