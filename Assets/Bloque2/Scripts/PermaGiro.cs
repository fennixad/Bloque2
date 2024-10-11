using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermaGiro : MonoBehaviour
{
    private Transform cuboGira;
    private float velGiro;
    void Start()
    {
        velGiro = 100f;
        cuboGira = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cuboGira.Rotate(Vector3.up * velGiro * Time.deltaTime);
    }
}
