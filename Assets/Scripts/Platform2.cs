using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
    public bool activated = false;

    private void OnCollisionEnter(Collision collision)
    {
        Cube cube = collision.gameObject.GetComponent<Cube>();
        if (cube.cubeNumber == 2) activated = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        activated = false;
    }
}