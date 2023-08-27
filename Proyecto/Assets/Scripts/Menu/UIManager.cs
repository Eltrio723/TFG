using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameManager _gameManager;

    private GameObject _menuPantallaInfo;
    private GameObject _menuPantallaPruebas;
    private GameObject _menuPantallaSaltar;
    private GameObject _menuPantallaFinPrueba;
    private GameObject _menuPantallaFinJuego;

    private GameObject _btnComenzar;
    private GameObject _btnEntendido;
    private GameObject _btnContinuar;
    private GameObject _btnReiniciar;
    private GameObject _btnTurismo;
    private GameObject _btnCancion;
    private GameObject _btnAsociacion;
    private GameObject _btnPosiciones;
    private GameObject _btnSituaciones;
    private GameObject _btnBaile;
    private GameObject _btnSonidos;
    private GameObject _btnLocalizacionSonidos;

    private GameObject _txtBienvenida;
    private GameObject _txtElige;
    private GameObject _txtInstrucciones;
    private GameObject _txtDescripcion;
    private GameObject _txtFinPrueba;
    private GameObject _txtFinJuego;



    void Start()
    {
        Init();
    }

    private void Init()
    {
        _gameManager = this.gameObject.GetComponent<GameManager>();

        //_menuPantalla = GameObject.Find("MenuPantalla");
        //_menuPantallaSiguiente = GameObject.Find("MenuPantallaSiguiente");
        _menuPantallaInfo = GameObject.Find("MenuPantallaInfo");
        _menuPantallaPruebas = GameObject.Find("MenuPantallaPruebas");
        _menuPantallaSaltar = GameObject.Find("MenuPantallaSaltar");
        _menuPantallaFinPrueba = GameObject.Find("MenuPantallaFinPrueba");
        _menuPantallaFinJuego = GameObject.Find("MenuPantallaFinJuego");
        _btnComenzar = GameObject.Find("btnComenzar");
        _btnEntendido = GameObject.Find("btnEntendido");
        _btnContinuar = GameObject.Find("btnContinuar");
        _btnReiniciar = GameObject.Find("btnReiniciar");
        _btnTurismo = GameObject.Find("btnTurismo");
        _btnCancion = GameObject.Find("btnCancion");
        _btnAsociacion = GameObject.Find("btnAsociacion");
        _btnPosiciones = GameObject.Find("btnPosiciones");
        _btnSituaciones = GameObject.Find("btnSituaciones");
        _btnBaile = GameObject.Find("btnBaile");
        _btnSonidos = GameObject.Find("btnSonidos");
        _btnLocalizacionSonidos = GameObject.Find("btnLocalizacionSonidos");
        _txtBienvenida = GameObject.Find("txtBienvenida");
        _txtElige = GameObject.Find("txtElige");
        _txtInstrucciones = GameObject.Find("txtInstrucciones");
        _txtDescripcion = GameObject.Find("txtDescripcion");
        _txtFinPrueba = GameObject.Find("txtFinPrueba");
        _txtFinJuego = GameObject.Find("txtFinJuego");

    }

    public void Iniciar()
    {
        PantallaTutorial();
    }

    public void TerminarTutorial()
    {
        PantallaPrincipal();
    }

    public void ComenzarEleccionPruebas(List<TipoPrueba> pruebasAMostrar)
    {
        MostrarBotonesPruebas(pruebasAMostrar);
    }

    public void ComenzarPrueba()
    {
        PantallaPrueba();
    }

    public void TerminarPrueba()
    {
        PantallaFinPrueba();
    }
    public void FinalJuego()
    {
        PantallaFinJuego();
    }

    public void btnEntendido()
    {
        _gameManager.TerminarTutorial();
    }

    public void btnComenzar()
    {
        _gameManager.ComenzarJuego();
    }

    public void btnSaltar()
    {
        _gameManager.SaltarPrueba();
    }

    public void btnContinuar()
    {
        _gameManager.NuevaRonda();
    }

    public void btnReiniciar()
    {
        _gameManager.ReiniciarJuego();
    }


    public void MostrarBotonesPruebas(List<TipoPrueba> pruebasAMostrar)
    {

        PantallaEleccion();
        for (int i = 0; i < pruebasAMostrar.Count; i++)
        {
            switch (pruebasAMostrar[i])
            {
                case TipoPrueba.Turismo:
                    _btnTurismo.SetActive(true);
                    break;
                case TipoPrueba.Cancion:
                    _btnCancion.SetActive(true);
                    break;
                case TipoPrueba.Asociacion:
                    _btnAsociacion.SetActive(true);
                    break;
                case TipoPrueba.Posiciones:
                    _btnPosiciones.SetActive(true);
                    break;
                case TipoPrueba.Situaciones:
                    _btnSituaciones.SetActive(true);
                    break;
                case TipoPrueba.Baile:
                    _btnBaile.SetActive(true);
                    break;
                case TipoPrueba.Sonidos:
                    _btnSonidos.SetActive(true);
                    break;
                case TipoPrueba.LocalizacionSonidos:
                    _btnLocalizacionSonidos.SetActive(true);
                    break;
                default:
                    break;
            }
        }



    }


    public void btnPrueba(int pruebaElegida)
    {

        _gameManager.SeleccionarPrueba((TipoPrueba)pruebaElegida);

    }

    private void DesactivarElementosUI()
    {
        _menuPantallaInfo.SetActive(false);
        _menuPantallaPruebas.SetActive(false);
        _menuPantallaSaltar.SetActive(false);
        _menuPantallaFinPrueba.SetActive(false);
        _menuPantallaFinJuego.SetActive(false);
        _btnComenzar.SetActive(false);
        _btnEntendido.SetActive(false);
        _btnContinuar.SetActive(false);
        _btnReiniciar.SetActive(false);
        _btnTurismo.SetActive(false);
        _btnCancion.SetActive(false);
        _btnAsociacion.SetActive(false);
        _btnPosiciones.SetActive(false);
        _btnSituaciones.SetActive(false);
        _btnBaile.SetActive(false);
        _btnSonidos.SetActive(false);
        _btnLocalizacionSonidos.SetActive(false);
        _txtBienvenida.SetActive(false);
        _txtElige.SetActive(false);
        _txtInstrucciones.SetActive(false);
        _txtDescripcion.SetActive(false);
        _txtFinPrueba.SetActive(false);
        _txtFinJuego.SetActive(false);
    }


    private void PantallaTutorial()
    {
        DesactivarElementosUI();
        _menuPantallaInfo.SetActive(true);
        _btnEntendido.SetActive(true);
        _txtInstrucciones.SetActive(true);


    }

    private void PantallaPrincipal()
    {
        DesactivarElementosUI();
        _menuPantallaInfo.SetActive(true);
        _txtBienvenida.SetActive(true);
        _btnComenzar.SetActive(true);
    }

    private void PantallaEleccion()
    {
        DesactivarElementosUI();
        _menuPantallaPruebas.SetActive(true);
        _txtElige.SetActive(true);
        _txtDescripcion.SetActive(true);
    }

    private void PantallaPrueba()
    {
        DesactivarElementosUI();
        _menuPantallaSaltar.SetActive(true);
    }

    private void PantallaFinPrueba()
    {
        DesactivarElementosUI();
        _menuPantallaFinPrueba.SetActive(true);
        _txtFinPrueba.SetActive(true);
        _btnContinuar.SetActive(true);
    }

    private void PantallaFinJuego()
    {
        DesactivarElementosUI();
        _menuPantallaFinJuego.SetActive(true);
        _txtFinJuego.SetActive(true);
        _btnReiniciar.SetActive(true);
    }



}
