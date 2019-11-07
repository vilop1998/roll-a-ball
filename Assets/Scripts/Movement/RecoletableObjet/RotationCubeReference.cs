using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCube : MonoBehaviour
{
    public int valuePoint;
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       rotation = new Vector3(15, 30, 45) * Time.deltaTime;
       transform.Rotate(rotation);
    }
}
