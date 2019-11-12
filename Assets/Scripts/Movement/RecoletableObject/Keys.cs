using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public Material mainMaterial;
    public float constantRotation = 5f;
    public Vector3 giro;


    void Start()
    {
        mainMaterial = GetComponent<Renderer>().material;
        giro = new Vector3(1f, 0f, 1f);



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

    private void Rotation()
    {
        
        transform.Rotate(giro * constantRotation * Time.deltaTime);
        
        //gameObject.transform.rotation = new Vector3(0f + constantRotation, 0f + constantRotation, 0f + constantRotation);
    }

    void Update()
    {
        Rotation();
        
    }
    
}
