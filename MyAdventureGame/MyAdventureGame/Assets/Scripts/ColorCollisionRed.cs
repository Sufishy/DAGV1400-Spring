using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCollisionRed : MonoBehaviour
{
    public Color newColor = Color.magenta;
    
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = newColor;
    }

    
}