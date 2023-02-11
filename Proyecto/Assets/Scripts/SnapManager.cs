using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
////using VRTK.Prefabs.Interactions.InteractableSnapZone;

public class SnapManager : MonoBehaviour
{

    ////public List<SnapZoneFacade> list;
    private bool completo;
    
    public bool correcto;


    // Start is called before the first frame update
    void Start()
    {
        ////list = GameObject.FindObjectsOfType<SnapZoneFacade>().ToList<SnapZoneFacade>();
    }

    // Update is called once per frame
    void Update()
    {
        completo = true;

        ////for (int i = 0; i < list.Count; i++)
        ////{
        ////    if (list[i].SnappedGameObject == null) 
        ////    {
        ////        completo = false;
        ////    }
        ////}

        if (completo)
        {
            correcto = CheckSnappedObjectsCorrect();
        }

        if (correcto)
        {
            GameObject.Find("ManagerPruebas").GetComponent<pruebaSonidos>().TerminarPrueba();
        }

    }



    public bool CheckSnappedObjectsCorrect()
    {
        bool correct = true;
        ////for (int i = 0; i < list.Count && correct; i++)
        ////{
        ////    correct = CheckSnappedTags(list[i].tag, list[i].SnappedGameObject.tag);
        ////}

        return correct;
    }


    public bool CheckSnappedTags(string snapZoneTag, string objectTag)
    {
        bool correct = false;

        switch (snapZoneTag)
        {
            case "SnapZone_cat1":
                if (objectTag == "SnappedObject_cat1")
                    correct = true;
                break;

            case "SnapZone_cat2":
                if (objectTag == "SnappedObject_cat2")
                    correct = true;
                break;

            default:
                break;
        }

        return correct;
    }










    public bool CheckAudioSourceVisible()
    {
        bool visible = false;

        visible = this.GetComponent<Renderer>().isVisible;

        return visible;
    }









}
