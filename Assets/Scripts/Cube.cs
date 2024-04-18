using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] int restrict = 0;

    public int cubeNumber = 0;

    private void Update()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

    public void Attach(Vector3 point, Vector3 startPos, Vector3 direction)
    {
        GetComponent<Rigidbody>().useGravity = false;
        transform.position = point - direction * 1.5f;
        if (point == new Vector3(0, 0, 0)) transform.position = startPos + direction * 2f;
        if (restrict == 1) transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Max(32,transform.position.z));
        if (restrict == 2) transform.position = new Vector3(Mathf.Max(-32, transform.position.x), transform.position.y, transform.position.z);
    }
}
