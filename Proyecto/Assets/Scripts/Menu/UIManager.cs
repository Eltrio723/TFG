using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameManager;

public class UIManager : MonoBehaviour
{
    //public GameObject pointer;

    //private GameManager gm;
    //private GameObject mp;
    //private GameObject menuPantalla;
    //private GameObject menuPantallaSiguiente;
    //private Button _btnComenzar;
    //private Button _btnTurismo;
    //private Button _btnCancion;
    //private Button _btnAsociacion;
    //private Button _btnPosiciones;
    //private Button _btnSituaciones;
    //private Button _btnBaile;
    //private Button _btnSonidos;
    //private Button _btnLocalizacionSonidos;
    //private GameObject _txtBienvenida;
    //private GameObject _txtElige;
    //private GameObject _txtInstrucciones;
    //private GameObject _txtDescripcion;



    //// Start is called before the first frame update
    //void Start()
    //{
    //    gm = FindObjectOfType<GameManager>();
    //    mp = GameObject.Find("ManagerPruebas");
    //    menuPantalla = GameObject.Find("MenuPantalla");
    //    menuPantallaSiguiente = GameObject.Find("MenuPantallaSiguiente");
    //    _btnComenzar = GameObject.Find("btnComenzar").GetComponent<Button>();
    //    _btnTurismo = GameObject.Find("btnTurismo").GetComponent<Button>();
    //    _btnCancion = GameObject.Find("btnCancion").GetComponent<Button>();
    //    _btnAsociacion = GameObject.Find("btnAsociacion").GetComponent<Button>();
    //    _btnPosiciones = GameObject.Find("btnPosiciones").GetComponent<Button>();
    //    _btnSituaciones = GameObject.Find("btnSituaciones").GetComponent<Button>();
    //    _btnBaile = GameObject.Find("btnBaile").GetComponent<Button>();
    //    _btnSonidos = GameObject.Find("btnSonidos").GetComponent<Button>();
    //    _btnLocalizacionSonidos = GameObject.Find("btnLocalizacionSonidos").GetComponent<Button>();
    //    _txtBienvenida = GameObject.Find("txt_bienvenida");
    //    _txtElige = GameObject.Find("txt_elige");
    //    _txtInstrucciones = GameObject.Find("txt_instrucciones");
    //    _txtDescripcion = GameObject.Find("txt_descripcion");

    //    Inicio();
    //}



    //public void btnEntendido()
    //{
    //    PantallaPrincipal();
    //}

    //public void btnComenzar()
    //{
    //    if (gm == null)
    //    {
    //        gm = FindObjectOfType<GameManager>();
    //    }

    //    if (mp == null)
    //    {
    //        mp = GameObject.Find("ManagerPruebas");
    //    }

    //    //_btnComenzar.gameObject.SetActive(false);
    //    PantallaEleccion();
    //    gm.Comenzar();
    //}

    //public void btnSaltar()
    //{
    //    gm.pruebaActual.TerminarPrueba();
    //}


    //public void CargarBotonesPruebas(List<int> ids)
    //{

    //    _txtBienvenida.SetActive(false);
    //    _txtElige.SetActive(true);
    //    menuPantalla.SetActive(true);
    //    menuPantallaSiguiente.SetActive(false);
    //    for (int i = 0; i < ids.Count; i++)
    //    {
    //        switch (ids[i])
    //        {
    //            case (int)Pruebas.Turismo:
    //                _btnTurismo.gameObject.SetActive(true);
    //                break;
    //            case (int)Pruebas.Cancion:
    //                _btnCancion.gameObject.SetActive(true);
    //                break;
    //            case (int)Pruebas.Asociacion:
    //                _btnAsociacion.gameObject.SetActive(true);
    //                break;
    //            case (int)Pruebas.Posiciones:
    //                _btnPosiciones.gameObject.SetActive(true);
    //                break;
    //            case (int)Pruebas.Situaciones:
    //                _btnSituaciones.gameObject.SetActive(true);
    //                break;
    //            case (int)Pruebas.Baile:
    //                _btnBaile.gameObject.SetActive(true);
    //                break;
    //            case (int)Pruebas.Sonidos:
    //                _btnSonidos.gameObject.SetActive(true);
    //                break;
    //            case (int)Pruebas.LocalizacionSonidos:
    //                _btnLocalizacionSonidos.gameObject.SetActive(true);
    //                break;
    //            default:
    //                break;
    //        }
    //    }

        

    //}

    //private void DesactivarBotonesPruebas()
    //{
    //    _btnTurismo.gameObject.SetActive(false);
    //    _btnCancion.gameObject.SetActive(false);
    //    _btnAsociacion.gameObject.SetActive(false);
    //    _btnPosiciones.gameObject.SetActive(false);
    //    _btnSituaciones.gameObject.SetActive(false);
    //    _btnBaile.gameObject.SetActive(false);
    //    _btnSonidos.gameObject.SetActive(false);
    //    _btnLocalizacionSonidos.gameObject.SetActive(false);
    //}


    //public void btnPrueba(int pruebaElegida)
    //{
    //    PantallaPrueba();

    //    var prueba = new Prueba();

    //    switch (pruebaElegida)
    //    {
    //        case (int)Pruebas.Turismo:
    //            prueba = mp.GetComponent<pruebaTurismo>();
    //            break;
    //        case (int)Pruebas.Cancion:
    //            prueba = mp.GetComponent<pruebaCancion>();
    //            break;
    //        case (int)Pruebas.Asociacion:
    //            prueba = mp.GetComponent<pruebaAsociacion>();
    //            break;
    //        case (int)Pruebas.Posiciones:
    //            prueba = mp.GetComponent<pruebaPosiciones>();
    //            break;
    //        case (int)Pruebas.Situaciones:
    //            prueba = mp.GetComponent<pruebaSituaciones>();
    //            break;
    //        case (int)Pruebas.Baile:
    //            prueba = mp.GetComponent<pruebaBaile>();
    //            break;
    //        case (int)Pruebas.Sonidos:
    //            prueba = mp.GetComponent<pruebaSonidos>();
    //            break;
    //        case (int)Pruebas.LocalizacionSonidos:
    //            prueba = mp.GetComponent<pruebaLocalizacionSonidos>();
    //            break;
    //        default:
    //            break;
    //    }

    //    gm.idPrueba = pruebaElegida;
    //    gm.pruebaActual = prueba;

    //    prueba.enabled = true;
    //    prueba.CargarPrueba();
        
    //}


    //private void PantallaTutorial()
    //{
    //    _txtBienvenida.SetActive(false);
    //    _txtElige.SetActive(false);
    //    _txtInstrucciones.SetActive(true);
    //    _txtDescripcion.SetActive(false);
    //    DesactivarBotonesPruebas();
    //    _btnComenzar.gameObject.SetActive(false);
    //    menuPantallaSiguiente.SetActive(false);
    //}

    //private void PantallaPrincipal()
    //{
    //    _txtBienvenida.SetActive(true);
    //    _txtElige.SetActive(false);
    //    _txtInstrucciones.SetActive(false);
    //    _txtDescripcion.SetActive(false);
    //    DesactivarBotonesPruebas();
    //    _btnComenzar.gameObject.SetActive(true);
    //    menuPantallaSiguiente.SetActive(false);
    //}

    //private void PantallaEleccion()
    //{
    //    _txtBienvenida.SetActive(false);
    //    _txtElige.SetActive(true);
    //    _txtInstrucciones.SetActive(false);
    //    _txtDescripcion.SetActive(true);
    //    DesactivarBotonesPruebas();
    //    _btnComenzar.gameObject.SetActive(false);
    //    menuPantallaSiguiente.SetActive(false);
    //}

    //private void PantallaPrueba()
    //{
    //    _txtBienvenida.SetActive(false);
    //    _txtElige.SetActive(false);
    //    _txtInstrucciones.SetActive(false);
    //    _txtDescripcion.SetActive(false);
    //    DesactivarBotonesPruebas();
    //    _btnComenzar.gameObject.SetActive(false);
    //    menuPantallaSiguiente.SetActive(true);
    //}

    //public void TerminarPrueba()
    //{
    //    PantallaEleccion();
    //}





    ///////////////////////////////////////////////////


    private GameManager _GameManager;

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
    private GameObject _txtInstrucciones;
    private GameObject _txtDescripcion;



    void Start()
    {
        Init();
    }

    private void Init()
    {
        _GameManager = this.gameObject.GetComponent<GameManager>();

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
        _txtInstrucciones = GameObject.Find("txt_instrucciones");
        _txtDescripcion = GameObject.Find("txt_descripcion");

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
        _GameManager.TerminarTutorial();
    }

    public void btnComenzar()
    {
        _GameManager.ComenzarJuego();
    }

    public void btnSaltar()
    {
        _GameManager.SaltarPrueba();
    }

    public void btnContinuar()
    {
        _GameManager.NuevaRonda();
    }

    public void btnTerminar()
    {
        _GameManager.TerminarJuego();
    }

    public void MostrarBotonesPruebas(List<TipoPrueba> pruebasAMostrar)
    {

        PantallaEleccion();
        for (int i = 0; i < pruebasAMostrar.Count; i++)
        {
            switch (pruebasAMostrar[i])
            {
                case TipoPrueba.Turismo:
                    _btnTurismo.gameObject.SetActive(true);
                    break;
                case TipoPrueba.Cancion:
                    _btnCancion.gameObject.SetActive(true);
                    break;
                case TipoPrueba.Asociacion:
                    _btnAsociacion.gameObject.SetActive(true);
                    break;
                case TipoPrueba.Posiciones:
                    _btnPosiciones.gameObject.SetActive(true);
                    break;
                case TipoPrueba.Situaciones:
                    _btnSituaciones.gameObject.SetActive(true);
                    break;
                case TipoPrueba.Baile:
                    _btnBaile.gameObject.SetActive(true);
                    break;
                case TipoPrueba.Sonidos:
                    _btnSonidos.gameObject.SetActive(true);
                    break;
                case TipoPrueba.LocalizacionSonidos:
                    _btnLocalizacionSonidos.gameObject.SetActive(true);
                    break;
                default:
                    break;
            }
        }



    }

    private void DesactivarBotonesPruebas()
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

        _GameManager.SeleccionarPrueba((TipoPrueba)pruebaElegida);


        //PantallaPrueba();

        //var prueba = new Prueba();

        //switch (pruebaElegida)
        //{
        //    case (int)Pruebas.Turismo:
        //        prueba = mp.GetComponent<pruebaTurismo>();
        //        break;
        //    case (int)Pruebas.Cancion:
        //        prueba = mp.GetComponent<pruebaCancion>();
        //        break;
        //    case (int)Pruebas.Asociacion:
        //        prueba = mp.GetComponent<pruebaAsociacion>();
        //        break;
        //    case (int)Pruebas.Posiciones:
        //        prueba = mp.GetComponent<pruebaPosiciones>();
        //        break;
        //    case (int)Pruebas.Situaciones:
        //        prueba = mp.GetComponent<pruebaSituaciones>();
        //        break;
        //    case (int)Pruebas.Baile:
        //        prueba = mp.GetComponent<pruebaBaile>();
        //        break;
        //    case (int)Pruebas.Sonidos:
        //        prueba = mp.GetComponent<pruebaSonidos>();
        //        break;
        //    case (int)Pruebas.LocalizacionSonidos:
        //        prueba = mp.GetComponent<pruebaLocalizacionSonidos>();
        //        break;
        //    default:
        //        break;
        //}

        //gm.idPrueba = pruebaElegida;
        //gm.pruebaActual = prueba;

        //prueba.enabled = true;
        //prueba.CargarPrueba();

    }


    private void PantallaTutorial()
    {
        _txtBienvenida.SetActive(false);
        _txtElige.SetActive(false);
        _txtInstrucciones.SetActive(true);
        _txtDescripcion.SetActive(false);
        DesactivarBotonesPruebas();
        _btnComenzar.gameObject.SetActive(false);
        menuPantallaSiguiente.SetActive(false);


    }

    private void PantallaPrincipal()
    {
        _txtBienvenida.SetActive(true);
        _txtElige.SetActive(false);
        _txtInstrucciones.SetActive(false);
        _txtDescripcion.SetActive(false);
        DesactivarBotonesPruebas();
        _btnComenzar.gameObject.SetActive(true);
        menuPantallaSiguiente.SetActive(false);
    }

    private void PantallaEleccion()
    {
        _txtBienvenida.SetActive(false);
        _txtElige.SetActive(true);
        _txtInstrucciones.SetActive(false);
        _txtDescripcion.SetActive(true);
        DesactivarBotonesPruebas();
        _btnComenzar.gameObject.SetActive(false);
        menuPantallaSiguiente.SetActive(false);
    }

    private void PantallaPrueba()
    {
        _txtBienvenida.SetActive(false);
        _txtElige.SetActive(false);
        _txtInstrucciones.SetActive(false);
        _txtDescripcion.SetActive(false);
        DesactivarBotonesPruebas();
        _btnComenzar.gameObject.SetActive(false);
        menuPantallaSiguiente.SetActive(true);
    }

    private void PantallaFinPrueba()
    {
        //_txtBienvenida.SetActive(false);
        //_txtElige.SetActive(false);
        //_txtInstrucciones.SetActive(false);
        //_txtDescripcion.SetActive(false);
        //DesactivarBotonesPruebas();
        //_btnComenzar.gameObject.SetActive(false);
        //menuPantallaSiguiente.SetActive(true);
    }

    private void PantallaFinJuego()
    {
        //_txtBienvenida.SetActive(false);
        //_txtElige.SetActive(false);
        //_txtInstrucciones.SetActive(false);
        //_txtDescripcion.SetActive(false);
        //DesactivarBotonesPruebas();
        //_btnComenzar.gameObject.SetActive(false);
        //menuPantallaSiguiente.SetActive(true);
    }



}
