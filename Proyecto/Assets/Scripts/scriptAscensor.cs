using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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

    private void Start()
    {

        targetAbajo = GameObject.Find("TargetAscensor").transform.position;
        targetArriba = new Vector3(0,0,0);
        speed = 1f;
        _enMovimiento = false;

    }

    public void BajarAscensor()
    {
        StartCoroutine(Bajar());
    }

    public void SubirAscensor()
    {
        StartCoroutine(Subir());
    }

    public bool IsAbajo()
    {
        return isAbajo;
    }

    public bool IsArriba()
    {
        return isArriba;
    }


    private void Update()
    {
        //if (bajar)
        //{
        //    float step = speed * Time.deltaTime; 
        //    transform.position = Vector3.MoveTowards(transform.position, targetAbajo, step);

        //    if (Vector3.Distance(transform.position, targetAbajo) < 0.001f)
        //    {
        //        bajar = false;
        //        isAbajo = true;
        //    }
        //}
        //else if (subir)
        //{
        //    float step = speed * Time.deltaTime; 
        //    transform.position = Vector3.MoveTowards(transform.position, targetArriba, step);

        //    if (Vector3.Distance(transform.position, targetArriba) < 0.001f)
        //    {
        //        subir = false;
        //        isArriba = true;
        //    }
        //}

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
        }

        yield return null;
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
            }
        }

        yield return null;
    }



}
