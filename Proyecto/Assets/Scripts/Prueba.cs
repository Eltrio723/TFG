using System.Collections.Generic;
using UnityEngine;


public class Prueba : MonoBehaviour
{
    protected GameObject ascensor;
    protected GameObject imagen;
    protected GameObject sonido;
    //protected int botonCorrecto;
    protected Vector3 posicionSonido;
    protected TriggerManager triggerManager;

    protected bool localizarSonido;


    //void Start()
    //{
    //    //activo = false;
    //    terminar = false;
    //    listo = false;
    //    triggerManager = GameObject.FindGameObjectWithTag("TriggerManager").GetComponent<TriggerManager>();

    //}

    //void Update()
    //{
    //    if (activo)
    //    {
    //        //// Va a empezar la prueba, el ascensor ya ha bajado, pero el nuevo no ha subido
    //        //if (!terminar && ascensorPrincipal.IsAbajo() && !nuevoAscensor.IsArriba())
    //        //{
    //        //    nuevoAscensor.SubirAscensor();
    //        //    if(listaObjetos != null && listaObjetos.Count > 0 && !objetosCreados)
    //        //    {
    //        //        CargarObjetos(listaObjetos);
    //        //    }
    //        //}

    //        ////El nuevo ascensor ya está arriba
    //        //if (!listo && nuevoAscensor.IsArriba() && !terminar)
    //        //{
    //        //    listo = true;
    //        //    if (imagen is not null)
    //        //    {
    //        //        CargarImagenPantalla(imagen);
    //        //    }
    //        //    if (sonido is not null)
    //        //    {
    //        //        CargarSonido(sonido);
    //        //    }
    //        //    if (pathTriggers is not null && pathTriggers != "")
    //        //    {
    //        //        triggerManager.CargarNivel(pathTriggers);
    //        //    }


    //        //    //CargarObjetos(listaObjetos);
    //        //}

    //        //// La prueba está terminanado, el ascensor de la prueba ya ha bajado
    //        //if (terminar && ((nuevoAscensor.IsAbajo() && ascensorPrincipal.IsAbajo()) || (nuevoAscensor == ascensorPrincipal)))
    //        //{
    //        //    if (ascensorPrincipal != nuevoAscensor)
    //        //    {
    //        //        Destroy(nuevoAscensor.gameObject);
    //        //        ascensorPrincipal.SubirAscensor();
    //        //    }
    //        //    else
    //        //    {
    //        //        nuevoAscensor = null;
    //        //    }

    //        //    FindObjectOfType<GameManager>().TerminarPrueba();
    //        //    terminar = false;
    //        //    activo = false;
    //        //    this.enabled = false;
    //        //}

    //        //// Saltar prueba
    //        //if (!terminar && Input.GetKeyDown(KeyCode.Space))
    //        //{
    //        //    TerminarPrueba();
    //        //}


    //        //// Evaluación prueba de localización de sonido
    //        //if (posicionSonido != null && !terminar && listo && localizarSonido)
    //        //{
    //        //    if (Vector3.Dot(Vector3.Normalize((GameObject.FindGameObjectWithTag("FuenteSonido").transform.position - GameObject.FindGameObjectWithTag("MainCamera").transform.position)), GameObject.FindGameObjectWithTag("MainCamera").transform.TransformDirection(Vector3.forward)) > 0.8f)
    //        //    {
    //        //        localizarSonido = false;
    //        //        PruebaCorrecta();

    //        //        //Debug.Log(Vector3.Dot(Vector3.Normalize((GameObject.FindGameObjectWithTag("FuenteSonido").transform.position - GameObject.FindGameObjectWithTag("MainCamera").transform.position)), GameObject.FindGameObjectWithTag("MainCamera").transform.TransformDirection(Vector3.forward)));


    //        //    }
    //        //}

    //    }

    //}

    //public virtual void CargarPrueba()
    //{

    //}




    //public void MoverAscensores()
    //{

    //    activo = true;
    //    ascensorPrincipal = GameObject.FindGameObjectWithTag("AscensorPrincipal").GetComponent<Ascensor>();

    //    if (ascensor != null)
    //    {
    //        listo = false;
    //        nuevoAscensor = Instantiate(ascensor, GameObject.Find("TargetAscensor").transform.position, Quaternion.identity).GetComponent<Ascensor>();
    //        nuevoAscensor.tag = "NuevoAscensor";
    //        ascensorPrincipal.BajarAscensor();
    //    }
    //    else
    //    {
    //        //listo = true;
    //        nuevoAscensor = ascensorPrincipal;
    //    }

    //}

    //public void TerminarPrueba()
    //{
    //    if(nuevoAscensor != ascensorPrincipal)
    //    {
    //        nuevoAscensor.BajarAscensor();
    //    }


    //    GameObject img = GameObject.FindGameObjectWithTag("ImagenPantalla"); 
    //    GameObject snd = GameObject.FindGameObjectWithTag("FuenteSonido");

    //    if (img != null)
    //    {
    //        Destroy(img);
    //    }

    //    if (snd != null)
    //    {
    //        Destroy(snd);
    //    }


    //    objetosCreados = false;
    //    listo = false;
    //    terminar = true;
    //}

    //public void CargarImagenPantalla(GameObject spr)
    //{
    //    if (spr != null)
    //    {
    //        GameObject canvas = GameObject.FindGameObjectWithTag("CanvasPantalla");
    //        GameObject img = Instantiate(spr, canvas.transform.position, canvas.transform.rotation);
    //        img.transform.SetParent(canvas.transform);
    //        //img.transform.parent = canvas.transform;
    //        img.transform.localScale = new Vector3(1, 1, 1);
    //        img.tag = "ImagenPantalla";
    //    }

    //}

    //public void CargarSonido(GameObject sonido)
    //{
    //    if (sonido != null)
    //    {

    //        if (posicionSonido != null)
    //        {
    //            GameObject test = new GameObject();
    //            GameObject test2 = Instantiate(test, (posicionSonido != null ? posicionSonido : Vector3.zero), Quaternion.identity);

    //            while (Vector3.Dot(Vector3.Normalize((test2.transform.position - GameObject.FindGameObjectWithTag("MainCamera").transform.position)), GameObject.FindGameObjectWithTag("MainCamera").transform.TransformDirection(Vector3.forward)) > 0)
    //            {
    //                posicionSonido = new Vector3();
    //                posicionSonido.x = Random.Range(-7f, 7f);
    //                posicionSonido.y = Random.Range(0f, 5f);
    //                posicionSonido.z = Random.Range(-7f, 7f);
    //                test2 = Instantiate(test, (posicionSonido != null ? posicionSonido : Vector3.zero), Quaternion.identity);
    //            }

    //        }


    //        GameObject snd = Instantiate(sonido, (posicionSonido != null ? posicionSonido : Vector3.zero), Quaternion.identity);

    //        snd.tag = "FuenteSonido";
    //    }

    //    if (botonCorrecto > 0)
    //    {
    //        GameObject boton = GameObject.Find("Button_" + botonCorrecto);
    //        ////boton.GetComponent<HoverButton>().onButtonIsPressed.AddListener(delegate { PruebaCorrecta(); });
    //    }



    //}

    //public void CargarObjetos(List<GameObject> objetos)
    //{

    //    List<GameObject> listaSpawns = GameObject.FindGameObjectsWithTag("SpawnMesa").ToList();

    //    for (int i = 0; i < listaSpawns.Count; i++)
    //    {
    //        GameObject obj = Instantiate(objetos[i], listaSpawns[i].transform);
    //        obj.tag = "ObjetoAsociacion";
    //    }
    //    objetosCreados = true;
    //}

    //public void PruebaCorrecta()
    //{
    //    Debug.Log("Prueba superada!");
    //    TerminarPrueba();

    //}






    /////////////////////////////////////////////////////


    protected PruebasManager _pruebasManager;
    protected bool correcto;

    public string pathImagen;
    public string pathSonido;
    public string pathTriggers;
    public List<string> listaPathObjetos;
    public List<string> listaRespuestas;
    public int respuestaCorrecta;

    //public List<GameObject> listaObjetos;

    public TipoPrueba tipo;

    void Start()
    {
        _pruebasManager = FindFirstObjectByType<PruebasManager>();
        correcto = false;
    }




    public virtual void PrepararDatos()
    {

    }

    public virtual bool CheckCorrecto()
    {
        return correcto;
    }

    public void MarcarCorrecto()
    {
        correcto = true;
    }








}
