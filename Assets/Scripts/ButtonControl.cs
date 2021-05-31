using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public ButtonManager.Option option;

    //public GameObject pointer;

    private GameManager gm;
    private GameObject mp;
    private ButtonManager bm;

    //private bool presionado;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        mp = GameObject.Find("ManagerPruebas");
        bm = FindObjectOfType<ButtonManager>();
    }

    public void PresionarBoton()
    {
        
        if (!bm.PuedePulsar())
        {
            return;
        }
        bm.BotonPulsado();


        Debug.Log("Botón pulsado");

        switch (option)
        {
            case ButtonManager.Option.Iniciar:

                if (gm == null)
                {
                    gm = FindObjectOfType<GameManager>();
                }

                if (mp == null)
                {
                    mp = GameObject.Find("ManagerPruebas");
                }

                gm.Comenzar();

                break;
            case ButtonManager.Option.TerminarPrueba:

                TerminarPrueba();

                break;
            case ButtonManager.Option.Asociacion:

                pruebaAsociacion p5 = mp.GetComponent<pruebaAsociacion>();
                p5.enabled = true;
                p5.CargarPrueba();
                gm.idPrueba = 5;
                Debug.Log("Iniciada prueba de asocición.");

                break;
            case ButtonManager.Option.Baile:

                pruebaBaile p4 = mp.GetComponent<pruebaBaile>();
                p4.enabled = true;
                p4.CargarPrueba();
                gm.idPrueba = 4;
                Debug.Log("Iniciada prueba de baile.");

                break;
            case ButtonManager.Option.Cancion:

                pruebaCancion p3 = mp.GetComponent<pruebaCancion>();
                p3.enabled = true;
                p3.CargarPrueba();
                gm.idPrueba = 3;
                Debug.Log("Iniciada prueba de adivina la canción.");

                break;
            case ButtonManager.Option.LocalizacionSonidos:

                pruebaLocalizacionSonidos p8 = mp.GetComponent<pruebaLocalizacionSonidos>();
                p8.enabled = true;
                p8.CargarPrueba();
                gm.idPrueba = 8;
                Debug.Log("Iniciada prueba de localización de sonidos.");

                break;
            case ButtonManager.Option.Posiciones:

                pruebaPosiciones p7 = mp.GetComponent<pruebaPosiciones>();
                p7.enabled = true;
                p7.CargarPrueba();
                gm.idPrueba = 7;
                Debug.Log("Iniciada prueba de posiciones.");

                break;
            case ButtonManager.Option.Situaciones:

                pruebaSituaciones p2 = mp.GetComponent<pruebaSituaciones>();
                p2.enabled = true;
                p2.CargarPrueba();
                gm.idPrueba = 2;
                Debug.Log("Iniciada prueba de situaciones.");

                break;
            case ButtonManager.Option.Sonidos:

                pruebaSonidos p6 = mp.GetComponent<pruebaSonidos>();
                p6.enabled = true;
                p6.CargarPrueba();
                gm.idPrueba = 6;
                Debug.Log("Iniciada prueba de sonidos.");

                break;
            case ButtonManager.Option.Turismo:

                pruebaTurismo p1 = mp.GetComponent<pruebaTurismo>();
                p1.enabled = true;
                p1.CargarPrueba();
                gm.idPrueba = 1;
                Debug.Log("Iniciada prueba de turismo.");

                break;
            default:
                Debug.LogWarning("Botón pulsado sin opción");
                break;
        }
    }



    void TerminarPrueba()
    {
        switch (gm.idPrueba)
        {
            case 1:
                pruebaTurismo p1 = GameObject.Find("ManagerPruebas").GetComponent<pruebaTurismo>();
                p1.TerminarPrueba();
                break;
            case 2:
                pruebaSituaciones p2 = GameObject.Find("ManagerPruebas").GetComponent<pruebaSituaciones>();
                p2.TerminarPrueba();
                break;
            case 3:
                pruebaCancion p3 = GameObject.Find("ManagerPruebas").GetComponent<pruebaCancion>();
                p3.TerminarPrueba();
                break;
            case 4:
                pruebaBaile p4 = GameObject.Find("ManagerPruebas").GetComponent<pruebaBaile>();
                p4.TerminarPrueba();
                break;
            case 5:
                pruebaAsociacion p5 = GameObject.Find("ManagerPruebas").GetComponent<pruebaAsociacion>();
                p5.TerminarPrueba();
                break;
            case 6:
                pruebaSonidos p6 = GameObject.Find("ManagerPruebas").GetComponent<pruebaSonidos>();
                p6.TerminarPrueba();
                break;
            case 7:
                pruebaPosiciones p7 = GameObject.Find("ManagerPruebas").GetComponent<pruebaPosiciones>();
                p7.TerminarPrueba();
                break;
            case 8:
                pruebaLocalizacionSonidos p8 = GameObject.Find("ManagerPruebas").GetComponent<pruebaLocalizacionSonidos>();
                p8.TerminarPrueba();
                break;
            default:
                break;
        }
        gm.idPrueba = 0;
        Debug.Log("Prueba finalizada.");
    }


}
