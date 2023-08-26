using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscenarioManager : MonoBehaviour
{

    public GameObject ascensorPrincipal;
    public GameObject ascensorTurismo;
    public GameObject ascensorCancion;
    public GameObject ascensorAsociacion;
    public GameObject ascensorPosiciones;
    public GameObject ascensorSituaciones;
    public GameObject ascensorBaile;
    public GameObject ascensorSonidos;
    public GameObject ascensorLocalizacionSonidos;

    private GameObject ascensorActual;

    private bool _escenarioListo;

    private GameObject _img;
    private GameObject _snd;

    // Start is called before the first frame update
    void Start()
    {
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

    }

    public void PrepararImagen(string path)
    {
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


    public void MostrarImagen()
    {
        _img.SetActive(true);
    }

    public void ReproducirSonido()
    {
        _snd.SetActive(true);

    }

}
