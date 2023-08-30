using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DetectManager : MonoBehaviour
{

    //private List<DetectZone> _zonas = new List<DetectZone>();
    private List<DetectZone> _zonasCatA = new List<DetectZone>();
    private List<DetectZone> _zonasCatB = new List<DetectZone>();
    public string tagCategoriaA;
    public string tagCategoriaB;
    private bool _correcto;

    // Start is called before the first frame update
    void Start()
    {
        List<DetectZone> _zonas = new List<DetectZone>();
        _zonasCatA = new List<DetectZone>();
        _zonasCatB = new List<DetectZone>();
        _correcto = false;


        _zonas = FindObjectsOfType<DetectZone>().ToList();
        for (int i = 0; i < _zonas.Count; i++)
        {
            if (_zonas[i].CompareTag(tagCategoriaA))
            {
                _zonasCatA.Add(_zonas[i]);
            }
            else if (_zonas[i].CompareTag(tagCategoriaB))
            {
                _zonasCatB.Add(_zonas[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public bool ComprobarCorrecto()
    {
        //if (_zonasCatA[0].ComprobarCorrecto().Equals(_zonasCatA[1].ComprobarCorrecto())
        //    && _zonasCatB[0].ComprobarCorrecto().Equals(_zonasCatB[1].ComprobarCorrecto()))
        //{
        //    _correcto = true;
        //}

        bool correctoParcial = true;
        bool hayObjetoValidoA = false;
        bool hayObjetoValidoB = true;

        List<bool> resultado = null;
        for (int i = 0; i < _zonasCatA.Count; i++)
        {
            if (resultado is null)
            {
                resultado = _zonasCatA[i].ComprobarCorrecto();
                hayObjetoValidoA = (resultado[0] || resultado[1]);
            }
            else if (!resultado.Equals(_zonasCatA[i].ComprobarCorrecto()))
            {
                correctoParcial = false;
            }
        }
        for (int i = 0; i < _zonasCatB.Count; i++)
        {
            if (resultado is null)
            {
                resultado = _zonasCatB[i].ComprobarCorrecto();
                hayObjetoValidoB = (resultado[0] || resultado[1]);
            }
            else if (!resultado.Equals(_zonasCatB[i].ComprobarCorrecto()))
            {
                correctoParcial = false;
            }
        }

        _correcto = correctoParcial && hayObjetoValidoA && hayObjetoValidoB;

        return _correcto;
    }


}
