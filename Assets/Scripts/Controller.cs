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
    [SerializeField] Platform6 platform6A;
    [SerializeField] Platform6 platform6B;
    [SerializeField] Platform6 platform6C;
    [SerializeField] Door door6;
    [SerializeField] Platform7 platform7A;
    [SerializeField] Platform7 platform7B;
    [SerializeField] Platform7 platform7C;
    [SerializeField] Platform7 platform7D;
    [SerializeField] Platform7 platform7E;
    [SerializeField] Platform7 platform7F;
    [SerializeField] Door door7;

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

        // Level 6
        if (platform6A.activated && platform6B.activated && platform6C.activated) door6.open = true;
        else door6.open = false;

        // Level 7
        if (platform7A.activated && platform7B.activated && platform7C.activated && platform7D.activated && platform7E.activated && platform7F.activated) door7.open = true;
        else door7.open = false;
    }
}
