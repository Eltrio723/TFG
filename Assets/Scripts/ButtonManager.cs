using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public enum Option { Iniciar, TerminarPrueba, Asociacion, Baile, Cancion, LocalizacionSonidos, Posiciones, Situaciones, Sonidos, Turismo };

    public bool presionado;

    void Start()
    {
        presionado = false;
    }


    public bool PuedePulsar()
    {
        return !presionado;
    }

    public void BotonPulsado()
    {
        presionado = true;
        StartCoroutine("VolverAPresionar");
    }


    IEnumerator VolverAPresionar()
    {
        yield return new WaitForSeconds(1);
        presionado = false;
    }



}
