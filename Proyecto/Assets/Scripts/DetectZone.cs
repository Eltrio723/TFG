using System.Collections.Generic;
using UnityEngine;

public class DetectZone : MonoBehaviour
{

    public List<GameObject> detectedObjects;
    public string categoria;
    public string categoriaSecundaria;
    [SerializeField]
    private bool _correcto;
    [SerializeField]
    private bool _correctoSecundaria;
    private int _numObjetosCategoria;
    private int _numObjetosCategoriaSecundaria;

    // Start is called before the first frame update
    void Start()
    {
        detectedObjects = new List<GameObject>();
        _numObjetosCategoria = 0;
        _correcto = false;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        detectedObjects.Add(other.gameObject);
        if (other.gameObject.tag == categoria)
        {
            _correcto = true;
            _numObjetosCategoria++;
        }
        else if (other.gameObject.tag == categoriaSecundaria)
        {
            _correctoSecundaria = true;
            _numObjetosCategoriaSecundaria++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        detectedObjects.Remove(other.gameObject);
        if (other.gameObject.tag == categoria)
        {
            _numObjetosCategoria--;
            if (_numObjetosCategoria < 1)
            {
                _correcto = false;
            }

        }
        else if (other.gameObject.tag == categoriaSecundaria)
        {
            _numObjetosCategoriaSecundaria--;
            if (_numObjetosCategoriaSecundaria < 1)
            {
                _correctoSecundaria = false;
            }

        }
    }


    public List<bool> ComprobarCorrecto()
    {
        return new List<bool> { _correcto, _correctoSecundaria };
    }

}
