using System.Collections;
using UnityEngine;

public class Ascensor : MonoBehaviour
{

    private bool bajar;
    private bool subir;

    private bool isArriba;
    private bool isAbajo;


    private Vector3 targetAbajo;
    private Vector3 targetArriba;
    private float speed;

    private bool _enMovimiento;
    private bool _haciaArriba;

    private EscenarioManager _escenarioManager;

    private void Start()
    {

        targetAbajo = GameObject.Find("TargetAscensor").transform.position;
        targetArriba = new Vector3(0, 0, 0);
        speed = 1f;
        _escenarioManager = FindFirstObjectByType<EscenarioManager>();
    }

    private void Update()
    {
        //if (_enMovimiento)
        //{
        //    //while (_enMovimiento)
        //    {
        //        float step = speed * Time.deltaTime;
        //        transform.position = Vector3.MoveTowards(transform.position, targetAbajo, step);

        //        if (Vector3.Distance(transform.position, targetAbajo) < 0.001f)
        //        {
        //            _enMovimiento = false;
        //            isAbajo = true;
        //        }
        //    }
        //}


        //if (_enMovimiento && _haciaArriba)
        //{
        //    float step = speed * Time.deltaTime;
        //    transform.position = Vector3.MoveTowards(transform.position, targetArriba, step);

        //    if (Vector3.Distance(transform.position, targetArriba) < 0.001f)
        //    {
        //        _enMovimiento = false;
        //        isArriba = true;
        //        _escenarioManager.TerminarCambioAscensor();
        //    }
        //}
    }

    public void BajarAscensor()
    {
        //Debug.LogWarning("Bajar Ascensor: " + this.gameObject.name);
        StartCoroutine(Bajar());
    }

    public void SubirAscensor()
    {
        //Debug.LogWarning("Subir Ascensor: " + this.gameObject.name);
        StartCoroutine(Subir());
        //_haciaArriba = true;
        //_enMovimiento = true;
    }

    public bool IsAbajo()
    {
        return isAbajo;
    }

    public bool IsArriba()
    {
        return isArriba;
    }





    IEnumerator Bajar()
    {
        isArriba = false;
        isAbajo = false;
        _enMovimiento = true;
        while (_enMovimiento)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetAbajo, step);

            if (Vector3.Distance(transform.position, targetAbajo) < 0.001f)
            {
                _enMovimiento = false;
                isAbajo = true;
            }
            yield return null;
        }


    }

    IEnumerator Subir()
    {
        isArriba = false;
        isAbajo = false;
        _enMovimiento = true;
        while (_enMovimiento)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetArriba, step);

            if (Vector3.Distance(transform.position, targetArriba) < 0.001f)
            {
                _enMovimiento = false;
                isArriba = true;
                _escenarioManager.TerminarCambioAscensor();
            }
            yield return null;
        }


    }



}
