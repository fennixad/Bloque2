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

    public float fuerzaSalto;
    public bool onGround;
    public bool doubleJump;

    void Start()
    {
        velocidad = 20f;
        velGiro = 100f;
        fuerzaSalto = 700;
        onGround = false;
        doubleJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        FreezeRotation();
        Sprint();
        Movimiento();

    }
    void FixedUpdate()
    {
        Jump();
    }

    void Movimiento()
    {
        ejex = Input.GetAxis("Horizontal") * Vector3.up * Time.deltaTime;
        ejey = Input.GetAxis("Jump") * Vector3.up * Time.deltaTime * velocidad;
        ejez = Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime * velocidad;

        transform.Translate(ejez);
        transform.Rotate(ejex, velGiro);
    }

    void FreezeRotation()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
    void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidad = 100f;
        }
    }

    void Jump()
    {
        if (onGround && Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzaSalto);
            Debug.Log("!He saltado");
            onGround = false;
        } 
        else if (!onGround && doubleJump && Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzaSalto);
            Debug.Log("Doble salto");
            doubleJump = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        onGround = true;
        doubleJump = true;
        Debug.Log("He tocado el suelo");
    }
}
