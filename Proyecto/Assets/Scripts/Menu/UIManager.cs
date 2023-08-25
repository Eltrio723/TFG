using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameManager;

public class UIManager : MonoBehaviour
{
    //public GameObject pointer;

    private GameManager gm;
    private GameObject mp;
    private GameObject menuPantalla;
    private GameObject menuPantallaSiguiente;
    private Button _btnComenzar;
    private Button _btnTurismo;
    private Button _btnCancion;
    private Button _btnAsociacion;
    private Button _btnPosiciones;
    private Button _btnSituaciones;
    private Button _btnBaile;
    private Button _btnSonidos;
    private Button _btnLocalizacionSonidos;
    private GameObject _txtBienvenida;
    private GameObject _txtElige;



    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        mp = GameObject.Find("ManagerPruebas");
        menuPantalla = GameObject.Find("MenuPantalla");
        menuPantallaSiguiente = GameObject.Find("MenuPantallaSiguiente");
        _btnComenzar = GameObject.Find("btnComenzar").GetComponent<Button>();
        _btnTurismo = GameObject.Find("btnTurismo").GetComponent<Button>();
        _btnCancion = GameObject.Find("btnCancion").GetComponent<Button>();
        _btnAsociacion = GameObject.Find("btnAsociacion").GetComponent<Button>();
        _btnPosiciones = GameObject.Find("btnPosiciones").GetComponent<Button>();
        _btnSituaciones = GameObject.Find("btnSituaciones").GetComponent<Button>();
        _btnBaile = GameObject.Find("btnBaile").GetComponent<Button>();
        _btnSonidos = GameObject.Find("btnSonidos").GetComponent<Button>();
        _btnLocalizacionSonidos = GameObject.Find("btnLocalizacionSonidos").GetComponent<Button>();
        _txtBienvenida = GameObject.Find("txt_bienvenida");
        _txtElige = GameObject.Find("txt_elige");
        _txtElige.SetActive(false);
        menuPantallaSiguiente.SetActive(false);
        DesactivarSeleccion();

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

        //transform.GetChild(0).gameObject.SetActive(false);
        //transform.GetChild(1).gameObject.SetActive(true);
        _btnComenzar.gameObject.SetActive(false);

        gm.Comenzar();
    }

    public void btnSaltar()
    {
        gm.pruebaActual.TerminarPrueba();
    }


    public void CargarBotonesPruebas(List<int> ids)
    {

        _txtBienvenida.SetActive(false);
        _txtElige.SetActive(true);
        menuPantalla.SetActive(true);
        menuPantallaSiguiente.SetActive(false);
        for (int i = 0; i < ids.Count; i++)
        {
            switch (ids[i])
            {
                case (int)Pruebas.Turismo:
                    _btnTurismo.gameObject.SetActive(true);
                    break;
                case (int)Pruebas.Cancion:
                    _btnCancion.gameObject.SetActive(true);
                    break;
                case (int)Pruebas.Asociacion:
                    _btnAsociacion.gameObject.SetActive(true);
                    break;
                case (int)Pruebas.Posiciones:
                    _btnPosiciones.gameObject.SetActive(true);
                    break;
                case (int)Pruebas.Situaciones:
                    _btnSituaciones.gameObject.SetActive(true);
                    break;
                case (int)Pruebas.Baile:
                    _btnBaile.gameObject.SetActive(true);
                    break;
                case (int)Pruebas.Sonidos:
                    _btnSonidos.gameObject.SetActive(true);
                    break;
                case (int)Pruebas.LocalizacionSonidos:
                    _btnLocalizacionSonidos.gameObject.SetActive(true);
                    break;
                default:
                    break;
            }
        }

        

    }

    private void DesactivarSeleccion()
    {
        _btnTurismo.gameObject.SetActive(false);
        _btnCancion.gameObject.SetActive(false);
        _btnAsociacion.gameObject.SetActive(false);
        _btnPosiciones.gameObject.SetActive(false);
        _btnSituaciones.gameObject.SetActive(false);
        _btnBaile.gameObject.SetActive(false);
        _btnSonidos.gameObject.SetActive(false);
        _btnLocalizacionSonidos.gameObject.SetActive(false);
    }


    public void btnPrueba(int pruebaElegida)
    {
        DesactivarSeleccion();
        menuPantalla.SetActive(false);
        menuPantallaSiguiente.SetActive(true);
        _txtElige.SetActive(false);

        var prueba = new Prueba();

        switch (pruebaElegida)
        {
            case (int)Pruebas.Turismo:
                prueba = mp.GetComponent<pruebaTurismo>();
                break;
            case (int)Pruebas.Cancion:
                prueba = mp.GetComponent<pruebaCancion>();
                break;
            case (int)Pruebas.Asociacion:
                prueba = mp.GetComponent<pruebaAsociacion>();
                break;
            case (int)Pruebas.Posiciones:
                prueba = mp.GetComponent<pruebaPosiciones>();
                break;
            case (int)Pruebas.Situaciones:
                prueba = mp.GetComponent<pruebaSituaciones>();
                break;
            case (int)Pruebas.Baile:
                prueba = mp.GetComponent<pruebaBaile>();
                break;
            case (int)Pruebas.Sonidos:
                prueba = mp.GetComponent<pruebaSonidos>();
                break;
            case (int)Pruebas.LocalizacionSonidos:
                prueba = mp.GetComponent<pruebaLocalizacionSonidos>();
                break;
            default:
                break;
        }

        gm.idPrueba = pruebaElegida;
        gm.pruebaActual = prueba;

        prueba.enabled = true;
        prueba.CargarPrueba();
        
    }

}
