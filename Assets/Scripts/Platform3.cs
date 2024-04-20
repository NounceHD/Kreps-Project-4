using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform3 : MonoBehaviour
{
    public bool activated = false;

    private void OnCollisionEnter(Collision collision)
    {
        Cube cube = collision.gameObject.GetComponent<Cube>();
        if (cube.cubeNumber == 2)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            activated = true;
        };
    }

    private void OnCollisionExit(Collision collision)
    {
        activated = false;
    }
}