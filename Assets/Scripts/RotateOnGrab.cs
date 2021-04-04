using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnGrab : MonoBehaviour
{

    public Vector3 rotacion;

    public void Rotar()
    {
        this.gameObject.transform.rotation = Quaternion.Euler(rotacion);
    }


}
