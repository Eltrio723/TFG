using Meta.WitAi;
using UnityEngine;

public class PruebasManager : MonoBehaviour
{
    public GameObject PrefabPruebaTurismo;
    public GameObject PrefabPruebaCancion;
    public GameObject PrefabPruebaAsociacion;
    public GameObject PrefabPruebaPosiciones;
    public GameObject PrefabPruebaSituaciones;
    public GameObject PrefabPruebaBaile;
    public GameObject PrefabPruebaSonidos;
    public GameObject PrefabPruebaLocalizacionSonidos;

    [SerializeField]
    private Prueba _pruebaActual;
    [SerializeField]
    private EscenarioManager _escenarioManager;
    [SerializeField]
    private TriggerManager _triggerManager;
    [SerializeField]
    private GameManager _gameManager;
    [SerializeField]
    private UIManager _uiManager;

    private bool _preparandoPrueba;
    private bool _terminanadoPrueba;


    // Start is called before the first frame update
    void Start()
    {
        _escenarioManager = this.gameObject.GetComponent<EscenarioManager>();
        _triggerManager = this.gameObject.GetComponent<TriggerManager>();
        _gameManager = this.gameObject.GetComponent<GameManager>();
        _uiManager = this.gameObject.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_preparandoPrueba)
        {
            if (_escenarioManager.GetEscenarioListo())
            {
                _preparandoPrueba = false;
                _gameManager.ComenzarPrueba(_pruebaActual.tipo);
            }
        }
        if (_terminanadoPrueba)
        {
            //_uiManager.TerminarPrueba();
            if (_escenarioManager.GetEscenarioListo())
            {
                _terminanadoPrueba = false;
                _gameManager.PruebaTerminada();
            }
        }
    }


    public void CrearPrueba(TipoPrueba tipoPrueba)
    {

        switch (tipoPrueba)
        {
            case TipoPrueba.Turismo:
                _pruebaActual = Instantiate(PrefabPruebaTurismo, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<PruebaTurismo>();
                break;
            case TipoPrueba.Cancion:
                _pruebaActual = Instantiate(PrefabPruebaCancion, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<PruebaCancion>();
                break;
            case TipoPrueba.Asociacion:
                _pruebaActual = Instantiate(PrefabPruebaAsociacion, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<PruebaAsociacion>();
                break;
            case TipoPrueba.Posiciones:
                _pruebaActual = Instantiate(PrefabPruebaPosiciones, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<PruebaPosiciones>();
                break;
            case TipoPrueba.Situaciones:
                _pruebaActual = Instantiate(PrefabPruebaSituaciones, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<PruebaSituaciones>();
                break;
            case TipoPrueba.Baile:
                _pruebaActual = Instantiate(PrefabPruebaBaile, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<PruebaBaile>();
                break;
            case TipoPrueba.Sonidos:
                _pruebaActual = Instantiate(PrefabPruebaSonidos, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<PruebaSonidos>();
                break;
            case TipoPrueba.LocalizacionSonidos:
                _pruebaActual = Instantiate(PrefabPruebaLocalizacionSonidos, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<PruebaLocalizacionSonidos>();
                break;
            default:
                break;
        }


        PrepararPrueba();
    }

    public void ComenzarPrueba()
    {
        //_pruebaActual.CargarPrueba();
        //_escenarioManager.MostrarImagen();
        //_escenarioManager.ReproducirSonido();
        //_triggerManager.ComenzarNivel();
        _escenarioManager.ComenzarPrueba();
    }

    public void TerminarPrueba()
    {
        _escenarioManager.TerminarPrueba(_pruebaActual);
        _terminanadoPrueba = true;
        _pruebaActual.gameObject.DestroySafely();
        _pruebaActual = null;
        //_escenarioManager.TerminarPrueba();
        //_gameManager.TerminarPrueba();
    }

    public void PrepararPrueba()
    {
        _preparandoPrueba = true;
        _pruebaActual.PrepararDatos();
        _escenarioManager.PrepararPrueba(_pruebaActual);
        _uiManager.PrepararBotonesRespuestas(_pruebaActual.listaRespuestas, _pruebaActual.respuestaCorrecta);

        //if (_pruebaActual.pathImagen is not null)
        //{
        //    _escenarioManager.PrepararImagen(_pruebaActual.pathImagen);
        //}

        //if (_pruebaActual.pathSonido is not null)
        //{
        //    _escenarioManager.PrepararSonido(_pruebaActual.pathSonido, (_pruebaActual.tipo == TipoPrueba.LocalizacionSonidos ? true : false));
        //}

        //if (_pruebaActual.pathTriggers is not null)
        //{
        //    //_escenarioManager.PrepararTriggers(_pruebaActual.pathTriggers);
        //    _triggerManager.CargarNivel(_pruebaActual.pathTriggers);
        //}

        //if (_pruebaActual.listaObjetos is not null && _pruebaActual.listaObjetos.Count > 0)
        //{
        //    _escenarioManager.PrepararObjetos(_pruebaActual.listaObjetos);
        //}
        //if (listaObjetos != null && listaObjetos.Count > 0 && !objetosCreados)
        //{
        //    CargarObjetos(listaObjetos);
        //}

        //if (_pruebaActual.tipo > 0)
        //{
        //    _escenarioManager.CambiarAscensor(_pruebaActual.tipo);
        //}




    }



    public bool CheckPruebaCorrecta()
    {
        bool correcto = false;
        if (_pruebaActual is not null)
        {
            correcto = _pruebaActual.CheckCorrecto();
        }
        return correcto;
    }



}
