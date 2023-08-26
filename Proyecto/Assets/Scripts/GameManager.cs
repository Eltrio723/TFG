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
        NuevaRonda();
    }

    public void NuevaRonda()
    {
        if (_pruebasRealizadas < _numeroPruebasARealizar)
        {
            TerminarJuego();
            return;
        }

        List<TipoPrueba> pruebas = ElegirPruebas();
        _UIManager.MostrarBotonesPruebas(pruebas);
        SetEstadoJuego(EstadoJuego.EleccionPrueba);
    }

    public void SeleccionarPrueba(TipoPrueba pruebaElegida)
    {
        CrearPrueba(pruebaElegida);
    }

    public void CrearPrueba(TipoPrueba pruebaElegida)
    {
        //Instanciar prefab de prueba adecuada
        _PruebasManager.CrearPrueba(pruebaElegida);
        ComenzarPrueba();
    }

    public void ComenzarPrueba()
    {

        _UIManager.ComenzarPrueba();
        SetEstadoJuego(EstadoJuego.Prueba);
        _PruebasManager.ComenzarPrueba();
    }

    public void TerminarPrueba()
    {
        _PruebasManager.TerminarPrueba();
        _UIManager.TerminarPrueba();
        SetEstadoJuego(EstadoJuego.FinPrueba);
        _pruebasRealizadas++;
        
    }



    public void TerminarJuego()
    {
        _UIManager.FinalJuego();
        SetEstadoJuego(EstadoJuego.Final);
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
    FinPrueba = 6,
    Final = 7
}
