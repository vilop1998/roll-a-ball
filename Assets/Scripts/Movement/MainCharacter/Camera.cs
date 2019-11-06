using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject target;
    private Vector3 offset;
    private void CalcularOffset()
    {
        offset = transform.position - target.transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        CalcularOffset();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + offset;   
    }
}
