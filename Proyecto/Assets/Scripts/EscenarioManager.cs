using Meta.WitAi;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EscenarioManager : MonoBehaviour
{
    [SerializeField]
    private TriggerManager _triggerManager;

    public GameObject ascensorPrincipal;
    public GameObject ascensorTurismo;
    public GameObject ascensorCancion;
    public GameObject ascensorAsociacion;
    public GameObject ascensorPosiciones;
    public GameObject ascensorSituaciones;
    public GameObject ascensorBaile;
    public GameObject ascensorSonidos;
    public GameObject ascensorLocalizacionSonidos;

    private GameObject _ascensorActual;
    private GameObject _ascensorNuevo;

    private bool _escenarioListo;

    private GameObject _img;
    private GameObject _snd;

    // Start is called before the first frame update
    void Start()
    {
        _triggerManager = this.gameObject.GetComponent<TriggerManager>();
        Instantiate(ascensorPrincipal);
        _escenarioListo = true;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public bool GetEscenarioListo()
    {
        return _escenarioListo;
    }


    public void CambiarAscensor(TipoPrueba tipoPrueba)
    {
        _escenarioListo = false;

        _ascensorActual.GetComponent<Ascensor>().BajarAscensor();

        switch (tipoPrueba)
        {
            case TipoPrueba.Turismo:
                _ascensorNuevo = Instantiate(ascensorTurismo, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity);
                break;
            case TipoPrueba.Cancion:
                _ascensorNuevo = Instantiate(ascensorCancion, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity);
                break;
            case TipoPrueba.Asociacion:
                _ascensorNuevo = Instantiate(ascensorAsociacion, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity);
                break;
            case TipoPrueba.Posiciones:
                _ascensorNuevo = Instantiate(ascensorPosiciones, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity);
                break;
            case TipoPrueba.Situaciones:
                _ascensorNuevo = Instantiate(ascensorSituaciones, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity);
                break;
            case TipoPrueba.Baile:
                _ascensorNuevo = Instantiate(ascensorBaile, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity);
                break;
            case TipoPrueba.Sonidos:
                _ascensorNuevo = Instantiate(ascensorSonidos, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity);
                break;
            case TipoPrueba.LocalizacionSonidos:
                _ascensorNuevo = Instantiate(ascensorLocalizacionSonidos, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity);
                break;
            default:
                //_ascensorNuevo = Instantiate(ascensorPrincipal, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity);
                break;
        }

        _ascensorNuevo.GetComponent<Ascensor>().SubirAscensor();

        _ascensorActual = _ascensorNuevo;
        _ascensorNuevo.DestroySafely();
        _ascensorNuevo = null;

        _escenarioListo = true;
    }

    public void PrepararImagen(string path)
    {
        if (path is null || path == "")
        {
            return;
        }
        GameObject spr = (GameObject)Resources.Load(path);
        if (spr != null)
        {
            GameObject canvas = GameObject.FindGameObjectWithTag("CanvasPantalla");
            _img = Instantiate(spr, canvas.transform.position, canvas.transform.rotation);
            _img.transform.SetParent(canvas.transform);
            //img.transform.parent = canvas.transform;
            _img.transform.localScale = new Vector3(1, 1, 1);
            _img.tag = "ImagenPantalla";
            _img.SetActive(false);
        }
    }

    public void PrepararSonido(string path, bool espacializado)
    {
        if (path is null || path == "")
        {
            return;
        }

        GameObject sonido = (GameObject)Resources.Load(path);
        if (sonido != null)
        {

            if (espacializado)
            {
                Vector3 posicionSonido = new Vector3();
                posicionSonido.x = Random.Range(-7f, 7f);
                posicionSonido.y = Random.Range(0f, 2f);
                posicionSonido.z = Random.Range(-7f, 7f);

                _snd = Instantiate(sonido, posicionSonido, Quaternion.identity);
                GameObject camara = GameObject.FindGameObjectWithTag("MainCamera");
                while (Vector3.Dot(Vector3.Normalize((_snd.transform.position - camara.transform.position)), camara.transform.TransformDirection(Vector3.forward)) > 0)
                {
                    posicionSonido = new Vector3();
                    posicionSonido.x = Random.Range(-7f, 7f);
                    posicionSonido.y = Random.Range(0f, 5f);
                    posicionSonido.z = Random.Range(-7f, 7f);
                    _snd = Instantiate(sonido, (posicionSonido != null ? posicionSonido : Vector3.zero), Quaternion.identity);
                }

            }
            else
            {
                _snd = Instantiate(sonido, Vector3.zero, Quaternion.identity);
            }


            _snd.tag = "FuenteSonido";
        }

        _snd.SetActive(false);

        //if (botonCorrecto > 0)
        //{
        //    GameObject boton = GameObject.Find("Button_" + botonCorrecto);
        //    ////boton.GetComponent<HoverButton>().onButtonIsPressed.AddListener(delegate { PruebaCorrecta(); });
        //}
    }


    public void PrepararObjetos(List<GameObject> objetos)
    {

        List<GameObject> listaSpawns = GameObject.FindGameObjectsWithTag("SpawnMesa").ToList();

        for (int i = 0; i < listaSpawns.Count; i++)
        {
            GameObject obj = Instantiate(objetos[i], listaSpawns[i].transform);
            obj.tag = "ObjetoAsociacion";
        }
    }

    public void PrepararTriggers(string path)
    {
        if (path is null || path == "")
        {
            return;
        }
        _triggerManager.CargarNivel(path);
    }


    public void MostrarImagen()
    {
        if (_img is not null)
        {
            _img.SetActive(true);
        }

    }

    public void ReproducirSonido()
    {
        if (_snd is not null)
        {
            _snd.SetActive(true);
        }
    }

    public void ComenzarPrueba()
    {
        MostrarImagen();
        ReproducirSonido();
        _triggerManager.ComenzarNivel();

    }


    public void PrepararPrueba(Prueba prueba)
    {
        //if (prueba.pathImagen is not null)
        //{
        PrepararImagen(prueba.pathImagen);
        //}

        //if (prueba.pathSonido is not null)
        //{
        PrepararSonido(prueba.pathSonido, (prueba.tipo == TipoPrueba.LocalizacionSonidos ? true : false));
        //}

        //if (prueba.pathTriggers is not null)
        //{
        PrepararTriggers(prueba.pathTriggers);
        //}

        //if (prueba.listaObjetos is not null && prueba.listaObjetos.Count > 0)
        //{
        //PrepararObjetos(prueba.listaObjetos);
        //}

        //if (prueba.tipo > 0)
        //{
        CambiarAscensor(prueba.tipo);
        //}

        PrepararObjetos(prueba.listaObjetos);
    }

    public void TerminarPrueba()
    {

    }

}
