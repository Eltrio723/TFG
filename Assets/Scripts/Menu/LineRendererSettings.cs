using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererSettings : MonoBehaviour
{

    //Declare a LineRenderer to store the component attached to the GameObject.
    [SerializeField] LineRenderer rend;

    //Settings for the LineRenderer are stired as a Vector3 array of points. Set up a V3 array to innitialize in Start.
    Vector3[] points;

    public LayerMask layerMask;

    public GameObject panel;
    public Image img;
    public Button btn;


    // Start is called before the first frame update
    void Start()
    {
        // get the LineRenderer attached to the gameoobject.
        rend = gameObject.GetComponent<LineRenderer>();

        //initialize the LineRenderer
        points = new Vector3[2];

        //set the start point of the linerenderer to the position of the gameObject.
        points[0] = Vector3.zero;

        //set the end point 20 units away from the GO on the Z axis (pointing forward)
        points[1] = transform.position + new Vector3(0, 0, 20);

        //finally set the positions array on the LineRenderer to our new values
        rend.SetPositions(points);
        rend.enabled = true;

        img = panel.GetComponent<Image>();

    }

    private void Update()
    {

        if (AlignLineRenderer(rend) && Input.GetAxis("Submit") > 0)
        {
            btn.onClick.Invoke();
        }

    }

    public bool AlignLineRenderer(LineRenderer rend)
    {
        Ray ray;
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction);
        bool hitBtn = false;


        if (Physics.Raycast(ray, out hit, layerMask))
        {
            points[1] = transform.forward + new Vector3(0,0, hit.distance);
            rend.startColor = Color.red;
            rend.endColor = Color.red;
            btn = hit.collider.gameObject.GetComponent<Button>();
            hitBtn = true;
        }
        else
        {
            points[1] = transform.forward + new Vector3(0, 0, 20);
            rend.startColor = Color.green;
            rend.endColor = Color.green;
            hitBtn = false;
        }

        rend.SetPositions(points);
        rend.material.color = rend.startColor;

        return hitBtn;
    }


    public void ColorChangeOnClick()
    {
        if (btn != null)
        {
            if (btn.name == "red_btn")
            {
                img.color = Color.red;
            }
            else if (btn.name == "blue_btn")
            {
                img.color = Color.blue;
            }
            else if (btn.name == "green_btn")
            {
                img.color = Color.green;
            }
        }
    }


}
