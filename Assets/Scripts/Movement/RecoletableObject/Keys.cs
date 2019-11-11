using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public Material mainMaterial;
    

    void Start()
    {
        mainMaterial = GetComponent<Renderer>().material;
        

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (mainMaterial.color == col.gameObject.GetComponent<Renderer>().material.color)
            {

                gameObject.SetActive(false);

            }
        }
    }
}
