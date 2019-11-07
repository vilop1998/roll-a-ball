using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlerJump : MonoBehaviour   
{
    public Rigidbody rb;
    private bool isGrounded;
    private void isJumping()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isJumping();
        }
    }
}
