using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaAsociacion : Prueba
{

    public override void CargarPrueba()
    {
        ascensor = (GameObject)Resources.Load("Escenarios/Esc_asociacion");
        listaObjetos = new List<GameObject>();

        switch (Random.Range(0, 3))
        {
            case 0:
                //Frutas (Manzana, plátano) vs Ropa (Zapato, guante) 
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Flor"));
                break;
            case 1:
                //Transporte (Avión, coche) vs Objetos de casa (Bombilla, teléfono)
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Flor"));
                break;
            case 2:
                //Plantas (Árbol, flor) vs Música (Guitarra, radio)
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Guitarra"));
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Arbol"));
                //listaObjetos.Add((GameObject)Resources.Load("Objetos/Radio"));
                listaObjetos.Add((GameObject)Resources.Load("Objetos/Flor"));
                break;
            default:
                break;
        }


        MoverAscensores();
    }
}
