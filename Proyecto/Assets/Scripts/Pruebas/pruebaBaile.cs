using UnityEngine;

public class PruebaBaile : Prueba
{
    void Start()
    {
        //CargarPrueba();
    }



    //public override void CargarPrueba()
    //{
    //    ascensor = null; 

    //    switch (Random.Range(0, 3))
    //    {
    //        case 0:
    //            pathTriggers = "Assets/Resources/Triggers/baile1.json";
    //            sonido = (GameObject)Resources.Load("Canciones/bai_chacacha");
    //            break;
    //        case 1:
    //            pathTriggers = "Assets/Resources/Triggers/baile2.json";
    //            sonido = (GameObject)Resources.Load("Canciones/bai_flechas"); 
    //            break;
    //        case 2:
    //            pathTriggers = "Assets/Resources/Triggers/baile3.json";
    //            sonido = (GameObject)Resources.Load("Canciones/bai_yeye");
    //            break;
    //        default:
    //            break;
    //    }


    //    MoverAscensores();
    //}

    public override void PrepararDatos()
    {
        tipo = TipoPrueba.Baile;
        usaPosiciones = true;

        switch (Random.Range(0, 3))
        {
            case 0:
                pathTriggers = "Assets/Resources/Triggers/baile1.json";
                //sonido = (GameObject)Resources.Load("Canciones/bai_chacacha");
                pathSonido = "Canciones/bai_chacacha";
                break;
            case 1:
                pathTriggers = "Assets/Resources/Triggers/baile2.json";
                //sonido = (GameObject)Resources.Load("Canciones/bai_flechas");
                pathSonido = "Canciones/bai_flechas";
                break;
            case 2:
                pathTriggers = "Assets/Resources/Triggers/baile3.json";
                //sonido = (GameObject)Resources.Load("Canciones/bai_yeye");
                pathSonido = "Canciones/bai_yeye";
                break;
            default:
                break;
        }

    }
    public override bool CheckCorrecto()
    {
        return correcto;
    }

}
