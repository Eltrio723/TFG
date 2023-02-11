using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

public class TriggerSpanwArray : MonoBehaviour
{
    [Tooltip("Trigger will move relative to this object")]
    private GameObject camera;

    [Tooltip("Root position for the array")]
    [SerializeField]
    private Vector3 position;

    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (camera != null)
        {
            gameObject.transform.position = camera.transform.position + new Vector3(0,0,0.3f) +
                this.transform.TransformDirection(position);
        }
    }


    public void loadTriggers(List<bool> positions)
    {


        //foreach (int i in indices)
        //{
        //    this.transform.GetChild(i).gameObject.SetActive(true);
        //}



        for (int i = 0; i < positions.Count; i++)
        {
            this.transform.GetChild(i).gameObject.SetActive(positions[i]);
        } 
    }

}
