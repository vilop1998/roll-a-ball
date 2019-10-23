using UnityEngine;

public class PlayerControlerBasicMovement01 : MonoBehaviour
{
    public float speed;
    public Rigidbody mainRigyBody;
    private void FixedUpdate()
    {
        float datoHorizontal, datoVertical;
        Vector3 movement;
        //Vector2 ejexz;
        datoHorizontal = Input.GetAxisRaw("Horizontal");
        datoVertical = Input.GetAxisRaw("Vertical");
        //ejexz = new Vector2(datoHorizontal, datoVertical);
        movement = new Vector3(datoHorizontal*speed, mainRigyBody.velocity.y, datoVertical*speed);
        mainRigyBody.velocity = movement;
        //mainRigyBody.velocity = ejexz * speed;
        
    }    
}
