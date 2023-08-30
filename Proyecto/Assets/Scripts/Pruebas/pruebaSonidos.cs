using System.Collections.Generic;
using UnityEngine;

public class PruebaSonidos : Prueba
{

    //public override void CargarPrueba()
    //{
    //    ascensor = (GameObject)Resources.Load("Escenarios/Esc_sonidos");
    //    listaObjetos = new List<GameObject>();

    //    listaObjetos.Add((GameObject)Resources.Load("Objetos/Coche"));
    //    listaObjetos.Add((GameObject)Resources.Load("Objetos/Pajaro"));
    //    listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra_no"));
    //    listaObjetos.Add((GameObject)Resources.Load("Objetos/Telefono"));

    //    switch (Random.Range(0, 3))
    //    {
    //        case 0:
    //            sonido = (GameObject)Resources.Load("Canciones/son_pajaro");
    //            botonCorrecto = 4;
    //            break;
    //        case 1:
    //            sonido = (GameObject)Resources.Load("Canciones/son_guitarra");
    //            botonCorrecto = 2;
    //            break;
    //        case 2:
    //            sonido = (GameObject)Resources.Load("Canciones/son_telefono");
    //            botonCorrecto = 1;
    //            break;
    //        default:
    //            break;
    //    }


    //    MoverAscensores();
    //}

    public override void PrepararDatos()
    {
        tipo = TipoPrueba.Sonidos;

        //listaObjetos = new List<GameObject>
        //{
        //    (GameObject)Resources.Load("Objetos/Coche"),
        //    (GameObject)Resources.Load("Objetos/Pajaro"),
        //    (GameObject)Resources.Load("Objetos/Guitarra_no"),
        //    (GameObject)Resources.Load("Objetos/Telefono")
        //};


        listaPathObjetos = new List<string>
        {
            "Objetos/Coche",
            "Objetos/Pajaro",
            "Objetos/Guitarra",
            "Objetos/Telefono"
        };

        //listaRespuestas = new List<string>
        //{
        //    "Telefono",
        //    "Guitarra",
        //    "Coche",
        //    "Pajaro"
        //};

        mensajePantalla = "Coloca en el pedestal el objeto que está produciendo el sonido";


        switch (Random.Range(0, 3))
        {
            case 0:
                //sonido = (GameObject)Resources.Load("Canciones/son_pajaro");
                pathSonido = "Canciones/son_pajaro";
                //respuestaCorrecta = 4;
                listaCategorias = new List<string>
                {
                    "",
                    "CatA",
                    "",
                    "",
                };
                break;
            case 1:
                //sonido = (GameObject)Resources.Load("Canciones/son_guitarra");
                pathSonido = "Canciones/son_guitarra";
                //respuestaCorrecta = 2;
                listaCategorias = new List<string>
                {
                    "",
                    "",
                    "CatA",
                    "",
                };
                break;
            case 2:
                //sonido = (GameObject)Resources.Load("Canciones/son_telefono");
                pathSonido = "Canciones/son_telefono";
                //respuestaCorrecta = 1;
                listaCategorias = new List<string>
                {
                    "",
                    "",
                    "",
                    "CatA",
                };
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
