
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public Material mainMaterial;
    public bool canTp;

    void Start()
    {
        mainMaterial = GetComponent<Renderer>().material;

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Boton"))
        {
            mainMaterial.color = col.gameObject.GetComponent<Renderer>().material.color;

        }

        if (col.gameObject.CompareTag("ColorWall"))
        {
            if (mainMaterial.color == col.gameObject.GetComponent<Renderer>().material.color)
            {

                col.gameObject.GetComponent<Collider>().isTrigger = true;

            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Tp"))
        {
            if (mainMaterial.color == col.gameObject.GetComponent<Renderer>().material.color)
            {

                canTp = true;

            }
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("ColorWall"))
        {
            col.gameObject.GetComponent<Collider>().isTrigger = false;
        }
    }

}
