using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

public class IndicacionesArray : MonoBehaviour
{
    [Tooltip("Trigger will move relative to this object")]
    private GameObject camera;

    [Tooltip("Root position for the array")]
    [SerializeField]
    private Vector3 position;

    void Start()
    {
        //camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        //if (camera != null)
        //{
        //    gameObject.transform.position = camera.transform.position +
        //        this.transform.TransformDirection(position);
        //}
    }


    public void loadIndicaciones(List<bool> positions)
    {

        for (int i = 0; i < positions.Count; i++)
        {
            this.transform.GetChild(i).gameObject.SetActive(positions[i]);
            this.transform.GetChild(i+12).gameObject.SetActive(!positions[i]);
        } 
    }

}
