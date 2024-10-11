using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input1 : MonoBehaviour
{
    public float velocidad;
    public float velGiro;
    public Vector3 ejex;
    public Vector3 ejey;
    public Vector3 ejez;

    void Start()
    {
        velocidad = 20f;
        velGiro = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        Sprint();

        ejex = Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * velocidad;
        ejey = Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime * velocidad;

        ejez = Input.GetAxis("Horizontal") * Vector3.up * Time.deltaTime * velGiro;

        transform.Translate(ejey + ejex);
        transform.Rotate(ejez);
    }

    void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidad = 100f;
        }
    }
}
