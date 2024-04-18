using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform4 : MonoBehaviour
{
    public bool activated = false;
    public bool cubeblue = false;
    public bool cubered = false;
    public bool cubeother = false;

    private void OnCollisionStay(Collision collision)
    {
        activated = false;
        Cube cube = collision.gameObject.GetComponent<Cube>();
        if (cube.cubeNumber == 3) cubeblue = true;
        if (cube.cubeNumber == 4) cubered = true;
        if (cube.cubeNumber != 3 && cube.cubeNumber != 4) cubeother = true;
        if (cubeblue && cubered && !cubeother) activated = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        activated = false;
        Cube cube = collision.gameObject.GetComponent<Cube>();
        if (cube.cubeNumber == 3) cubeblue = false;
        if (cube.cubeNumber == 4) cubered = false;
        if (cube.cubeNumber != 3 && cube.cubeNumber != 4) cubeother = false;
        if (cubeblue && cubered && !cubeother) activated = true;
    }
}
