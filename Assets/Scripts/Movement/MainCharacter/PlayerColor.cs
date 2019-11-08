
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public Material mainMaterial;
    
    Transform mainObjectTransform;

    void Start()
    {
        mainMaterial = GetComponent<Renderer>().material;
        
        mainObjectTransform = GetComponent<Transform>();
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

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Tp"))
        {
            print("Hola"); 
            //quiero que me cambie la posición pero no lo hace, sin embargo, si me destruye la pelota.
            Vector3 newPosition = new Vector3(0f, 0f, 0f);
            mainObjectTransform.position = newPosition;
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
