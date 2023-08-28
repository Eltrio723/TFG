using System.Collections.Generic;
using UnityEngine;

public class TriggerSpanwArray : MonoBehaviour
{
    [Tooltip("Trigger will move relative to this object")]
    private GameObject camara;

    [Tooltip("Root position for the array")]
    [SerializeField]
    private Vector3 position;

    void Start()
    {
        camara = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (camara != null)
        {
            gameObject.transform.position = camara.transform.position + new Vector3(0, 0, 0.3f) +
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
