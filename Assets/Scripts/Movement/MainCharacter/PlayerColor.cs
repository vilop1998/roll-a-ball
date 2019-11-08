using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public Material mainMaterial;
    public bool isGrounded;
    Collider mainObjectCollider;

    void Start()
    {
        mainMaterial = GetComponent<Renderer>().material;
        mainObjectCollider = GetComponent<Collider>();
        mainObjectCollider.isTrigger = false;
    }

    private void OnCollisionEnter(Collision boton)
    {
        if (boton.gameObject.CompareTag("Boton"))
        {
            mainMaterial.color = boton.gameObject.GetComponent<Renderer>().material.color;

        }

    }

    private void OnTriggerEnter(Collider pared)
    {
        if (pared.gameObject.CompareTag("ColorWall"))
        {

            //pared.gameObject.GetComponent<Collider>().isTrigger = true;
            //Collider.isTrigger = true;

            if (mainMaterial.color == pared.gameObject.GetComponent<Renderer>().material.color)
            {

                pared.gameObject.GetComponent<Collider>().isTrigger = true;

            }
        }

    }

}