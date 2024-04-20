using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform7 : MonoBehaviour
{
    [SerializeField] int cubeNumber = 0;
    public bool activated = false;

    private void OnCollisionEnter(Collision collision)
    {
        Cube cube = collision.gameObject.GetComponent<Cube>();
        if (cube.cubeNumber == cubeNumber) activated = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Cube cube = collision.gameObject.GetComponent<Cube>();
        if (cube.cubeNumber == cubeNumber) activated = false;
    }
}
