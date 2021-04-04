using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static private int numPruebas = 8;

    public int idPrueba;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("AscensorPrincipal").GetComponent<scriptAscensor>().Subir();
        idPrueba = 0;
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

        FindObjectOfType<UIManager>().CargarBotonesPruebas(ids);
    }

}
