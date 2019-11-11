using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    public GameObject key;

    private void OnCollisionEnter(Collision col)
    {
        if(key.activeSelf == false)
        {
                GetComponent<Collider>().isTrigger = true;
        }
        
    }
}
