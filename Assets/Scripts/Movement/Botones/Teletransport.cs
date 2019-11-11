using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransport : MonoBehaviour
{
    public Vector3 destinationPosition;
    public GameObject player;
    public Transform ballTransform;
    public Collider ballCollider;
    private bool checkPosition;
    Vector3 wildcardPosition;
    
   
    void Start()
    {
        checkPosition = true;
        //Tambien funciona con new Vector3
        wildcardPosition = ballTransform.transform.position;
    }
    void OnTriggerEnter(Collider col)
    {        
        wildcardPosition = destinationPosition;
        checkPosition = false;
    }
    void FixedUpdate()
    {
        if(player.GetComponent<PlayerColor>().canTp) 
            {
            if (checkPosition == true)
            {
                wildcardPosition = ballTransform.transform.position;
            }
            else
            {
                ballTransform.transform.position = wildcardPosition;
                checkPosition = true;
            }
        }

    }

}
