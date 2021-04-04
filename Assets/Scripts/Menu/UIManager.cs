using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject pointer;

    private GameManager gm;
    private GameObject mp;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        mp = GameObject.Find("ManagerPruebas");
    }



    public void btnComenzar()
    {
        if (gm == null)
        {
            gm = FindObjectOfType<GameManager>();
        }

        if (mp == null)
        {
            mp = GameObject.Find("ManagerPruebas");
        }

        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);

        gm.Comenzar();
    }


    public void CargarBotonesPruebas(List<int> ids)
    {
        transform.GetChild(1).gameObject.SetActive(true);
        pointer.SetActive(true);
        GameObject panel = GameObject.Find("PanelBotonesPruebas");
        panel.transform.GetChild(ids[0]-1).gameObject.SetActive(true);
        panel.transform.GetChild(ids[1]-1).gameObject.SetActive(true);
    }

    private void DesactivarSeleccion()
    {
        pointer.SetActive(false);
        GameObject panel = GameObject.Find("PanelBotonesPruebas");
        for (int i = 0; i < panel.transform.childCount; i++)
        {
            panel.transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(1).gameObject.SetActive(false);
    }


    public void btnTurismo()
    {
        pruebaTurismo p1 = mp.GetComponent<pruebaTurismo>();
        p1.enabled = true;
        p1.CargarPrueba();
        gm.idPrueba = 1;
        DesactivarSeleccion();
        Debug.Log("Iniciada prueba de turismo.");
    }

    public void btnSituaciones()
    {
        pruebaSituaciones p2 = mp.GetComponent<pruebaSituaciones>();
        p2.enabled = true;
        p2.CargarPrueba();
        gm.idPrueba = 2;
        DesactivarSeleccion();
        Debug.Log("Iniciada prueba de situaciones.");
    }

    public void btnCancion()
    {
        pruebaCancion p3 = mp.GetComponent<pruebaCancion>();
        p3.enabled = true;
        p3.CargarPrueba();
        gm.idPrueba = 3;
        DesactivarSeleccion();
        Debug.Log("Iniciada prueba de adivina la canción.");
    }

    public void btnBaile()
    {
        pruebaBaile p4 = mp.GetComponent<pruebaBaile>();
        p4.enabled = true;
        p4.CargarPrueba();
        gm.idPrueba = 4;
        DesactivarSeleccion();
        Debug.Log("Iniciada prueba de baile.");
    }

    public void btnAsociacion()
    {
        pruebaAsociacion p5 = mp.GetComponent<pruebaAsociacion>();
        p5.enabled = true;
        p5.CargarPrueba();
        gm.idPrueba = 5;
        DesactivarSeleccion();
        Debug.Log("Iniciada prueba de asocición.");
    }

    public void btnSonidos()
    {
        pruebaSonidos p6 = mp.GetComponent<pruebaSonidos>();
        p6.enabled = true;
        p6.CargarPrueba();
        gm.idPrueba = 6;
        DesactivarSeleccion();
        Debug.Log("Iniciada prueba de sonidos.");
    }

    public void btnPosiciones()
    {
        pruebaPosiciones p7 = mp.GetComponent<pruebaPosiciones>();
        p7.enabled = true;
        p7.CargarPrueba();
        gm.idPrueba = 7;
        DesactivarSeleccion();
        Debug.Log("Iniciada prueba de posiciones.");
    }

    public void btnLocalizacionSonidos()
    {
        pruebaLocalizacionSonidos p8 = mp.GetComponent<pruebaLocalizacionSonidos>();
        p8.enabled = true;
        p8.CargarPrueba();
        gm.idPrueba = 8;
        DesactivarSeleccion();
        Debug.Log("Iniciada prueba de localización de sonidos.");
    }



}
