using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] float speed = 50.0f;
    [SerializeField] int orientation = 0;

    private Transform side1;
    private Transform side2;

    public bool open = false;
    private float percentClosed = 100;

    private void Update()
    {
        if ((open && percentClosed >= 100) || (!open && percentClosed <= 0))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }

        if (orientation == 0)
        {
            if (open && percentClosed > 0) percentClosed -= speed * Time.deltaTime;
            if (!open && percentClosed < 100) percentClosed += speed * Time.deltaTime;

            float x1 = percentClosed / -50 + 3;
            float x2 = percentClosed / 50 - 3;
            side1.position = new Vector3(x1, 3, 0) + transform.position;
            side2.position = new Vector3(x2, 3, 0) + transform.position;
        }

        if (orientation == 1)
        {
            if (open && percentClosed > 0) percentClosed -= speed * Time.deltaTime;
            if (!open && percentClosed < 100) percentClosed += speed * Time.deltaTime;

            float z1 = percentClosed / -50 + 3;
            float z2 = percentClosed / 50 - 3;
            side1.position = new Vector3(0, 3, z1) + transform.position;
            side2.position = new Vector3(0, 3, z2) + transform.position;
        }
    }

    private void Start()
    {
        side1 = transform.GetChild(0);
        side2 = transform.GetChild(1);
    }
}
