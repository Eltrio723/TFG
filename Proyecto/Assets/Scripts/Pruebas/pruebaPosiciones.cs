using UnityEngine;

public class PruebaPosiciones : Prueba
{


    //public override void CargarPrueba()
    //{
    //    ascensor = null;

    //    switch (Random.Range(0, 3))
    //    {
    //        case 0:
    //            pathTriggers = "Assets/Resources/Triggers/posiciones1.json";
    //            break;
    //        case 1:
    //            pathTriggers = "Assets/Resources/Triggers/posiciones2.json";
    //            break;
    //        case 2:
    //            pathTriggers = "Assets/Resources/Triggers/posiciones3.json";
    //            break;
    //        default:
    //            break;
    //    }


    //    MoverAscensores();
    //}


    public override void PrepararDatos()
    {
        tipo = TipoPrueba.Posiciones;

        switch (Random.Range(0, 3))
        {
            case 0:
                pathTriggers = "Assets/Resources/Triggers/posiciones1.json";
                break;
            case 1:
                pathTriggers = "Assets/Resources/Triggers/posiciones2.json";
                break;
            case 2:
                pathTriggers = "Assets/Resources/Triggers/posiciones3.json";
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
