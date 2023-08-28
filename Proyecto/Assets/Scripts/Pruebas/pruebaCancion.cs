using System.Collections.Generic;
using UnityEngine;

public class PruebaCancion : Prueba
{
    void Start()
    {
        //CargarPrueba();
    }



    //public override void CargarPrueba()
    //{
    //    ascensor = (GameObject)Resources.Load("Escenarios/Esc_adivina_cancion");

    //    switch (Random.Range(0, 3))
    //    {
    //        case 0:
    //            sonido = (GameObject)Resources.Load("Canciones/can_gardenias");
    //            break;
    //        case 1:
    //            sonido = (GameObject)Resources.Load("Canciones/can_espania");
    //            break;
    //        case 2:
    //            sonido = (GameObject)Resources.Load("Canciones/can_luna");
    //            break;
    //        default:
    //            break;
    //    }


    //    MoverAscensores();
    //}

    public override void PrepararDatos()
    {
        tipo = TipoPrueba.Cancion;

        switch (Random.Range(0, 3))
        {
            case 0:
                //sonido = (GameObject)Resources.Load("Canciones/can_gardenias");
                pathSonido = "Canciones/can_gardenias";
                respuestaCorrecta = 1;
                break;
            case 1:
                //sonido = (GameObject)Resources.Load("Canciones/can_espania");
                pathSonido = "Canciones/can_espania";
                respuestaCorrecta = 2;
                break;
            case 2:
                //sonido = (GameObject)Resources.Load("Canciones/can_luna");
                pathSonido = "Canciones/can_luna";
                respuestaCorrecta = 3;
                break;
            default:
                break;
        }

        listaRespuestas = new List<string>
        {
            "Antonio Machín",
            "Manolo Escobar",
            "Los Bocheros",
            "Lola Flores"
        };

    }
    public override bool CheckCorrecto()
    {
        return false;
    }
}
