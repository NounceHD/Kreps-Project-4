using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] Platform1 platform1;
    [SerializeField] Door door1;
    [SerializeField] Platform2 platform2;
    [SerializeField] Door door2;
    [SerializeField] Platform3 platform3;
    [SerializeField] Door door3;
    [SerializeField] Platform4 platform4;
    [SerializeField] Door door4;
    [SerializeField] Platform5 platform5A;
    [SerializeField] Platform5 platform5B;
    [SerializeField] Door door5;

    private void Update()
    {
        // Level 1  
        if (platform1.activated) door1.open = true;
        else door1.open = false;

        // Level 2
        if (platform2.activated) door2.open = true;
        else door2.open = false;

        // Level 3
        if (platform3.activated) door3.open = true;
        else door3.open = false;

        // Level 4
        if (platform4.activated) door4.open = true;
        else door4.open = false;

        // Level 5
        if (!platform5A.activated && !platform5B.activated) door5.open = true;
        else door5.open = false;
    }
}
