using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform8 : MonoBehaviour
{
    public bool activated = false;

    private void OnCollisionEnter(Collision collision)
    {
        Cube cube = collision.gameObject.GetComponent<Cube>();
        if (cube.cubeNumber == 14) activated = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Cube cube = collision.gameObject.GetComponent<Cube>();
        if (cube.cubeNumber == 14) activated = false;
    }
}
