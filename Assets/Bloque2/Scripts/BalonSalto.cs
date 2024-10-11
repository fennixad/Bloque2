using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonSalto : MonoBehaviour
{
    Vector3 jump;
    [SerializeField]
    float fuerza;
    bool onGround;
    bool jumpMomentum;
    

    void Start()
    {
        onGround = false;
        fuerza = 500f;
    }

    void FixedUpdate()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetButton("Jump") && onGround)
        {
            Debug.Log("Salto");
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerza);
            onGround = false;
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Toco suelo");
        onGround = true;
    }
}
