using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private UIManager _UIManager;
    private PruebasManager _PruebasManager;
    private EscenarioManager _EscenarioManager;

    private EstadoJuego _estado;
    [SerializeField]
    private int _numeroPruebasARealizar;
    private int _pruebasRealizadas;
    private Prueba _pruebaActual;

    void Start()
    {
        InitManagers();
        IniciarJuego();
    }

    private void InitManagers()
    {
        _UIManager = this.gameObject.GetComponent<UIManager>();
        _PruebasManager = this.gameObject.GetComponent<PruebasManager>();
        _EscenarioManager = this.gameObject.GetComponent<EscenarioManager>();
    }

    public void SetEstadoJuego(EstadoJuego estado)
    {
        _estado = estado;
    }

    public EstadoJuego GetEstadoJuego()
    {
        return _estado;
    }

    private void IniciarJuego()
    {
        _pruebasRealizadas = 0;
        SetEstadoJuego(EstadoJuego.Arrancado);
        _UIManager.Iniciar();
        SetEstadoJuego(EstadoJuego.Tutorial);
    }

    public void TerminarTutorial()
    {
        _UIManager.TerminarTutorial();
        SetEstadoJuego(EstadoJuego.Listo);
    }

    public void ComenzarJuego()
    {
        List<TipoPrueba> pruebas = ElegirPruebas();
        _UIManager.MostrarBotonesPruebas(pruebas);
        SetEstadoJuego(EstadoJuego.EleccionPrueba);
    }

    public void CrearPrueba(TipoPrueba pruebaElegida)
    {
        //Instanciar prefab de prueba adecuada
        _pruebaActual = _PruebasManager.CrearPrueba(pruebaElegida);
        ComenzarPrueba(_pruebaActual);
    }

    public void ComenzarPrueba(Prueba prueba)
    {

        _UIManager.ComenzarPrueba();
        prueba.CargarPrueba();
        SetEstadoJuego(EstadoJuego.Prueba);
    }

    public void TerminarPrueba()
    {
        _UIManager.TerminarPrueba();
        _pruebaActual = null;

        if (_pruebasRealizadas < _numeroPruebasARealizar)
        {
            //Volver a elegir prueba
            SetEstadoJuego(EstadoJuego.Listo);
        }
        else
        {
            //El juego se termina
            SetEstadoJuego(EstadoJuego.Fin);
        }
        
    }


    public void SaltarPrueba()
    {
        TerminarPrueba();
    }

    public List<TipoPrueba> ElegirPruebas()
    {

        int numPruebas = Enum.GetValues(typeof(EstadoJuego)).Length;

        List<TipoPrueba> pruebasAElegir = new List<TipoPrueba>();
        TipoPrueba primeraPrueba = (TipoPrueba)UnityEngine.Random.Range(1, numPruebas + 1);
        TipoPrueba segundaPrueba = (TipoPrueba)UnityEngine.Random.Range(1, numPruebas + 1);

        pruebasAElegir.Add(primeraPrueba);
        
        while (pruebasAElegir.Contains(segundaPrueba))
        {
            segundaPrueba = (TipoPrueba)UnityEngine.Random.Range(1, numPruebas + 1);
        }

        pruebasAElegir.Add(segundaPrueba);

        return pruebasAElegir;
    }

}


public enum TipoPrueba
{
    Turismo = 1,
    Cancion = 2,
    Asociacion = 3,
    Posiciones = 4,
    Situaciones = 5,
    Baile = 6,
    Sonidos = 7,
    LocalizacionSonidos = 8
}

public enum EstadoJuego
{
    Arrancado = 1,
    Tutorial = 2,
    Listo = 3,
    EleccionPrueba = 4,
    Prueba = 5,
    Fin = 6
}
