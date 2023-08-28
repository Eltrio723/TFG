using UnityEngine;

public class PruebaLocalizacionSonidos : Prueba
{

    //public override void CargarPrueba()
    //{
    //    ascensor = null;


    //    posicionSonido = new Vector3();
    //    posicionSonido.x = Random.Range(-7f, 7f);
    //    posicionSonido.y = Random.Range(0f, 2f);
    //    posicionSonido.z = Random.Range(-7f, 7f);

    //    sonido = (GameObject)Resources.Load("Canciones/loc_chacacha");

    //    localizarSonido = true;

    //    MoverAscensores();
    //}

    public override void PrepararDatos()
    {
        tipo = TipoPrueba.LocalizacionSonidos;

        posicionSonido = new Vector3();
        posicionSonido.x = Random.Range(-7f, 7f);
        posicionSonido.y = Random.Range(0f, 2f);
        posicionSonido.z = Random.Range(-7f, 7f);

        //sonido = (GameObject)Resources.Load("Canciones/loc_chacacha");
        pathSonido = "Canciones/loc_chacacha";


    }

    public override bool CheckCorrecto()
    {
        bool correcto = false;
        GameObject fuenteSonido = GameObject.FindGameObjectWithTag("FuenteSonido");
        GameObject camara = GameObject.FindGameObjectWithTag("MainCamera");
        if (Vector3.Dot(Vector3.Normalize((fuenteSonido.transform.position - camara.transform.position)), camara.transform.TransformDirection(Vector3.forward)) > 0.8f)
        {
            correcto = true;
        }
        return correcto;
    }


}
