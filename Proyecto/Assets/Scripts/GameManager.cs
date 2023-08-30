using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UIManager _uiManager;
    [SerializeField]
    private PruebasManager _pruebasManager;
    [SerializeField]
    private EscenarioManager _escenarioManager;

    private EstadoJuego _estado;
    [SerializeField]
    private int _numeroPruebasARealizar;
    private int _pruebasRealizadas;

    private bool _testing;


    void Start()
    {
        InitManagers();
        IniciarJuego();
        _testing = true;
    }

    private void Update()
    {
        // Saltar prueba
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SaltarPrueba();
        }


        if (_estado == EstadoJuego.Prueba && _pruebasManager.CheckPruebaCorrecta())
        {
            PruebaCorrecta();
        }
    }

    private void InitManagers()
    {
        _uiManager = this.gameObject.GetComponent<UIManager>();
        _pruebasManager = this.gameObject.GetComponent<PruebasManager>();
        _escenarioManager = this.gameObject.GetComponent<EscenarioManager>();
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
        _uiManager.Iniciar();
        SetEstadoJuego(EstadoJuego.Tutorial);
    }

    public void TerminarTutorial()
    {
        _uiManager.TerminarTutorial();
        SetEstadoJuego(EstadoJuego.Listo);
    }

    public void ComenzarJuego()
    {
        NuevaRonda();
    }

    public void NuevaRonda()
    {
        if (_pruebasRealizadas >= _numeroPruebasARealizar)
        {
            TerminarJuego();
            return;
        }

        List<TipoPrueba> pruebas = ElegirPruebas();
        _uiManager.MostrarBotonesPruebas(pruebas);
        SetEstadoJuego(EstadoJuego.EleccionPrueba);
    }

    public void SeleccionarPrueba(TipoPrueba pruebaElegida)
    {
        CrearPrueba(pruebaElegida);
    }

    public void CrearPrueba(TipoPrueba pruebaElegida)
    {
        //Instanciar prefab de prueba adecuada
        _pruebasManager.CrearPrueba(pruebaElegida);

        //ComenzarPrueba();
    }

    public void ComenzarPrueba(TipoPrueba tipo)
    {

        _uiManager.ComenzarPrueba(tipo);
        SetEstadoJuego(EstadoJuego.Prueba);
        _pruebasManager.ComenzarPrueba();
    }

    public void TerminarPrueba()
    {
        _pruebasManager.TerminarPrueba();

    }

    public void PruebaTerminada()
    {
        _uiManager.TerminarPrueba();
        SetEstadoJuego(EstadoJuego.FinPrueba);
        _pruebasRealizadas++;
    }



    public void TerminarJuego()
    {
        _uiManager.FinalJuego();
        SetEstadoJuego(EstadoJuego.Final);
    }

    public void ReiniciarJuego()
    {
        IniciarJuego();
    }


    public void SaltarPrueba()
    {
        TerminarPrueba();
    }

    public void PruebaCorrecta()
    {
        TerminarPrueba();
    }

    public List<TipoPrueba> ElegirPruebas()
    {

        if (_testing)
        {
            List<TipoPrueba> pruebas = new List<TipoPrueba>()
            {
                //TipoPrueba.Turismo,
                //TipoPrueba.Cancion,
                TipoPrueba.Asociacion,
                //TipoPrueba.Posiciones,
                //TipoPrueba.Situaciones,
                //TipoPrueba.Baile,
                TipoPrueba.Sonidos,
                //TipoPrueba.LocalizacionSonidos
            };
            return pruebas;
        }

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
