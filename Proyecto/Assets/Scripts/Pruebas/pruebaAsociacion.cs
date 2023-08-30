using System.Collections.Generic;
using UnityEngine;

public class PruebaAsociacion : Prueba
{

    private DetectManager _detectManager;

    //public override void CargarPrueba()
    //{
    //    ascensor = (GameObject)Resources.Load("Escenarios/Esc_asociacion");
    //    listaObjetos = new List<GameObject>();

    //    switch (Random.Range(0, 3))
    //    {
    //        case 0:
    //            //Frutas (Manzana, plátano) vs Ropa (Zapato, guante) 
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
    //            //listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Flor"));
    //            break;
    //        case 1:
    //            //Transporte (Avión, coche) vs Objetos de casa (Bombilla, teléfono)
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
    //            //listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Flor"));
    //            break;
    //        case 2:
    //            //Plantas (Árbol, flor) vs Música (Guitarra, radio)
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
    //            //listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
    //            listaObjetos.Add((GameObject)Resources.Load("Objetos/Flor"));
    //            break;
    //        default:
    //            break;
    //    }


    //    MoverAscensores();
    //}

    public override void PrepararDatos()
    {
        tipo = TipoPrueba.Asociacion;
        //listaObjetos = new List<GameObject>();

        Debug.LogWarning("Faltan objetos por asignar: Bombilla, Manzana, Platano, Zapato, Guante");
        _detectManager = FindFirstObjectByType<DetectManager>();
        mensajePantalla = "Coloca en los pedestales de cada lado los objetos con algo en común";

        switch (Random.Range(0, 3))
        {
            case 0:
                ////Frutas (Manzana, plátano) vs Ropa (Zapato, guante) 
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Flor"));

                listaPathObjetos = new List<string>
                {
                    "Objetos/Radio",
                    "Objetos/Guitarra",
                    "Objetos/Arbol",
                    "Objetos/Flor",
                };

                listaCategorias = new List<string>
                {
                    "CatA",
                    "CatA",
                    "CatB",
                    "CatB",
                };

                break;
            case 1:
                ////Transporte (Avión, coche) vs Objetos de casa (Bombilla, teléfono)
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Coche"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Telefono"));

                listaPathObjetos = new List<string>
                {
                    "Objetos/Radio",
                    "Objetos/Avion",
                    "Objetos/Coche",
                    "Objetos/Telefono",
                };
                listaCategorias = new List<string>
                {
                    "CatA",
                    "CatB",
                    "CatB",
                    "CatA",
                };

                break;
            case 2:
                ////Plantas (Árbol, flor) vs Música (Guitarra, radio)
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Flor"));

                listaPathObjetos = new List<string>
                {
                    "Objetos/Arbol",
                    "Objetos/Radio",
                    "Objetos/Guitarra",
                    "Objetos/Flor",
                };
                listaCategorias = new List<string>
                {
                    "CatA",
                    "CatB",
                    "CatB",
                    "CatA",
                };

                break;
            default:
                break;
        }
        //Pruebas
        listaPathObjetos = new List<string>
                {
                    "Objetos/Arbol",
                    "Objetos/Radio",
                    "Objetos/Guitarra",
                    "Objetos/Flor",
                };
        listaCategorias = new List<string>
                {
                    "CatA",
                    "CatB",
                    "CatB",
                    "CatA",
                };

    }

    public override bool CheckCorrecto()
    {
        return _detectManager.ComprobarCorrecto();
    }
}
