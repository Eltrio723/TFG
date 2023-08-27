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

        listaObjetos = new List<GameObject>
        {
            (GameObject)Resources.Load("Objetos/Coche"),
            (GameObject)Resources.Load("Objetos/Pajaro"),
            (GameObject)Resources.Load("Objetos/Guitarra_no"),
            (GameObject)Resources.Load("Objetos/Telefono")
        };

        switch (Random.Range(0, 3))
        {
            case 0:
                sonido = (GameObject)Resources.Load("Canciones/son_pajaro");
                botonCorrecto = 4;
                break;
            case 1:
                sonido = (GameObject)Resources.Load("Canciones/son_guitarra");
                botonCorrecto = 2;
                break;
            case 2:
                sonido = (GameObject)Resources.Load("Canciones/son_telefono");
                botonCorrecto = 1;
                break;
            default:
                break;
        }


    }

}
