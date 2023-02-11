using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{


    [Tooltip("Prefab for the trigger spawn array")]
    public GameObject triggerSpawnArray;
    public GameObject indicacionesArray;


    [System.Serializable]
    public class Part
    {
        public float time;
        public List<bool> triggerPositions;
    }

    [System.Serializable]
    public class Level
    {
        public List<Part> parts;
    }

    //private TriggerPositions level;

    public bool correct;

    public int aciertos;



    public void CargarNivel(string path)
    {
        aciertos = 0;

        StreamReader reader = new StreamReader(path);
        string json = reader.ReadToEnd();
        reader.Close();



        Level level = JsonUtility.FromJson<Level>(json);



        triggerSpawnArray = GameObject.FindGameObjectWithTag("TriggerSpawnArray");
        indicacionesArray = GameObject.FindGameObjectWithTag("IndicacionesArray");

        for (int i = 0; i < level.parts.Count; i++)
        {
            StartCoroutine(LoadLevel(level.parts[i].triggerPositions, level.parts[i].time));
        }


    }


    private void Update()
    {
        //GameObject[] triggers = GameObject.FindGameObjectsWithTag("Trigger");

        //bool todosCorrectos = true;

        //for (int i = 0; i < triggers.Length; i++)
        //{
        //    if(triggers[i].activeInHierarchy && !triggers[i].GetComponent<scriptTrigger>().controllerInside)
        //    {
        //        todosCorrectos = false;
        //    }
        //}

        //correct = todosCorrectos;


        if (aciertos > 2)
        {
            correct = true;
            pruebaBaile pb = FindObjectOfType<pruebaBaile>();
            if(pb != null)
            {
                pb.PruebaCorrecta();
            }

            pruebaPosiciones pp = FindObjectOfType<pruebaPosiciones>();
            if (pp != null)
            {
                pp.PruebaCorrecta();
            }
            aciertos = 0;
        }
    }



    IEnumerator LoadLevel(List<bool> lista, float seconds)
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(seconds);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        if (CheckCorrect())
        {
            aciertos++;
        }

        triggerSpawnArray.GetComponent<TriggerSpanwArray>().loadTriggers(lista);
        indicacionesArray.GetComponent<IndicacionesArray>().loadIndicaciones(lista);

    }


    private bool CheckCorrect()
    {
        bool correcto = true;
        GameObject[] triggers = GameObject.FindGameObjectsWithTag("Trigger");
        for (int i = 0; i < triggers.Length; i++)
        {
            correcto = correcto && triggers[i].GetComponent<scriptTrigger>().controllerInside;
            Debug.Log("Inside: " + triggers[i].GetComponent<scriptTrigger>().controllerInside);
        }
        Debug.Log(triggers.Length + " - " + correcto);
        return correcto;
    }

}
