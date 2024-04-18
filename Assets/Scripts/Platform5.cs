using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform5 : MonoBehaviour
{
    public bool activated = false;

    private void OnCollisionEnter(Collision collision)
    {
        Scale scale = collision.gameObject.GetComponent<Scale>();
        if (scale) activated = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Scale scale = collision.gameObject.GetComponent<Scale>();
        if (scale) activated = false;
    }
}
