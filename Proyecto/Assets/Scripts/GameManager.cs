using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private UIManager _UIManager;

    static private int numPruebas = 8;

    public int idPrueba;

    public Prueba pruebaActual;

    public enum Pruebas
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

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("AscensorPrincipal").GetComponent<scriptAscensor>().Subir();
        idPrueba = 0;
        _UIManager = FindFirstObjectByType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Comenzar()
    {
        Debug.Log("COMENZAR");

        ActivarSeleccion();

    }

    public void TerminarPrueba()
    {
        ActivarSeleccion();
    }

    public void ActivarSeleccion()
    {


        List<int> ids = new List<int>();

        ids.Add(Random.Range(1, numPruebas + 1));
        int nuevoId = Random.Range(1, numPruebas + 1);
        while (ids.Contains(nuevoId))
        {
            nuevoId = Random.Range(1, numPruebas + 1);
        }

        ids.Add(nuevoId);

        _UIManager.CargarBotonesPruebas(ids);
    }

}
