using UnityEngine;

public class TriggerControl : MonoBehaviour
{

    [Tooltip("Shows if a controller is inside the trigger")]
    [SerializeField]
    public bool controllerInside;

    [Tooltip("Name of the tag used for the controllers")]
    public string controllerTag;

    [Tooltip("This material will be used when a controller is inside the trigger")]
    public Material correctMaterial;
    [Tooltip("This material will be used when a controller is outside the trigger")]
    public Material incorrectMaterial;

    [Tooltip("Number of controllers inside the trigger")]
    [SerializeField]
    private int nControllers;


    void Start()
    {
        //if (controllerTag == "")
        //{
        controllerTag = "Hand";
        //}
        nControllers = 0;
    }

    private void Update()
    {
        if (nControllers > 0)
        {
            GetComponent<MeshRenderer>().material = correctMaterial;
            controllerInside = true;
        }
        else
        {
            GetComponent<MeshRenderer>().material = incorrectMaterial;
            controllerInside = false;
        }

        nControllers = Mathf.Clamp(nControllers, 0, 2);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.tag == controllerTag)
        {
            nControllers++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == controllerTag)
        {
            nControllers--;
        }
    }

    public void Reiniciar()
    {
        nControllers = 0;
        GetComponent<MeshRenderer>().material = incorrectMaterial;
        controllerInside = false;
    }


}
