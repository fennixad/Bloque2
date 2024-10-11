using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MostrarAltura : MonoBehaviour
{
    public TMP_Text text;
    public float puntuacion;

    void Update()
    {
        puntuacion = transform.position.y;

        text.text = "Altura: " + puntuacion.ToString("F2");
    }
}
