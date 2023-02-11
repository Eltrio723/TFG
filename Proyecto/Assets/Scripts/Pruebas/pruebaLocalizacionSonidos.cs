using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaLocalizacionSonidos : Prueba
{

    public override void CargarPrueba()
    {
        ascensor = null;


        posicionSonido = new Vector3();
        posicionSonido.x = Random.Range(-7f, 7f);
        posicionSonido.y = Random.Range(0f, 2f);
        posicionSonido.z = Random.Range(-7f, 7f);

        sonido = (GameObject)Resources.Load("Canciones/loc_chacacha");

        localizarSonido = true;

        MoverAscensores();
    }



}
