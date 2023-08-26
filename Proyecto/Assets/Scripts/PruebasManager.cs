using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
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

    private Prueba _pruebaActual;
    private EscenarioManager _escenarioManager;
    private TriggerManager _triggerManager;


    // Start is called before the first frame update
    void Start()
    {
        _escenarioManager = this.gameObject.GetComponent<EscenarioManager>();
        _triggerManager = this.gameObject.GetComponent<TriggerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CrearPrueba(TipoPrueba tipoPrueba)
    {

        switch (tipoPrueba)
        {
            case TipoPrueba.Turismo:
                _pruebaActual = Instantiate(PrefabPruebaTurismo, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<pruebaTurismo>();
                break;
            case TipoPrueba.Cancion:
                _pruebaActual = Instantiate(PrefabPruebaCancion, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<pruebaTurismo>();
                break;
            case TipoPrueba.Asociacion:
                _pruebaActual = Instantiate(PrefabPruebaAsociacion, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<pruebaTurismo>();
                break;
            case TipoPrueba.Posiciones:
                _pruebaActual = Instantiate(PrefabPruebaPosiciones, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<pruebaTurismo>();
                break;
            case TipoPrueba.Situaciones:
                _pruebaActual = Instantiate(PrefabPruebaSituaciones, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<pruebaTurismo>();
                break;
            case TipoPrueba.Baile:
                _pruebaActual = Instantiate(PrefabPruebaBaile, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<pruebaTurismo>();
                break;
            case TipoPrueba.Sonidos:
                _pruebaActual = Instantiate(PrefabPruebaSonidos, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<pruebaTurismo>();
                break;
            case TipoPrueba.LocalizacionSonidos:
                _pruebaActual = Instantiate(PrefabPruebaLocalizacionSonidos, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<pruebaTurismo>();
                break;
            default:
                break;
        }

        
        PrepararPrueba();
    }

    public void ComenzarPrueba()
    {
        //_pruebaActual.CargarPrueba();
        _escenarioManager.MostrarImagen();
        _escenarioManager.ReproducirSonido();
        _triggerManager.ComenzarNivel();
    }

    public void TerminarPrueba()
    {
        _pruebaActual.gameObject.DestroySafely();
        _pruebaActual = null;
    }

    public void PrepararPrueba()
    {

        _pruebaActual.PrepararDatos();

        if (_pruebaActual.pathImagen is not null)
        {
            _escenarioManager.PrepararImagen(_pruebaActual.pathImagen);
        }

        if (_pruebaActual.pathSonido is not null)
        {
            _escenarioManager.PrepararSonido(_pruebaActual.pathSonido, (_pruebaActual.tipo == TipoPrueba.LocalizacionSonidos ? true : false));
        }

        if (_pruebaActual.pathTriggers is not null)
        {
            //_escenarioManager.PrepararTriggers(_pruebaActual.pathTriggers);
            _triggerManager.CargarNivel(_pruebaActual.pathTriggers);
        }

        if (_pruebaActual.tipo > 0)
        {
            _escenarioManager.CambiarAscensor(_pruebaActual.tipo);
        }


    }

    

    

}
