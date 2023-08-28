using UnityEngine;

public class PruebaSituaciones : Prueba
{
    void Start()
    {
        //CargarPrueba();
    }





    //public override void CargarPrueba()
    //{
    //    ascensor = null; //(GameObject)Resources.Load("Escenarios/Esc_vacio");

    //    switch (Random.Range(0, 3))
    //    {
    //        case 0:
    //            imagen = (GameObject)Resources.Load("Imagenes/img_medico");
    //            break;
    //        case 1:
    //            imagen = (GameObject)Resources.Load("Imagenes/img_cole");
    //            break;
    //        case 2:
    //            imagen = (GameObject)Resources.Load("Imagenes/img_feria");
    //            break;
    //        default:
    //            break;
    //    }


    //    MoverAscensores();
    //}


    public override void PrepararDatos()
    {
        tipo = TipoPrueba.Situaciones;

        switch (Random.Range(0, 3))
        {
            case 0:
                //imagen = (GameObject)Resources.Load("Imagenes/img_medico");
                pathImagen = "Imagenes/img_medico";
                break;
            case 1:
                //imagen = (GameObject)Resources.Load("Imagenes/img_cole");
                pathImagen = "Imagenes/img_cole";
                break;
            case 2:
                //imagen = (GameObject)Resources.Load("Imagenes/img_feria");
                pathImagen = "Imagenes/img_feria";
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
