using UnityEngine;
using UnityEngine.UI;

public class PlayerControlerBasicMovement01 : MonoBehaviour
{
    public float speed;
    public Rigidbody mainRigyBody;
    private int score;
    public Text scoreText;
    //public bool Control = true;
    //private Text winText;

    //movimiento chapuza
    /*private void Start()
    {
        mainRigyBody = GetComponent<Rigidbody>();
        score = 0;
        SetCountText();
        //winText.text = "";
       

    }*/
    private void FixedUpdate()
    {

       // if (Control)
        
            float datoHorizontal, datoVertical;
            Vector3 movement;
            datoHorizontal = Input.GetAxisRaw("Horizontal");
            datoVertical = Input.GetAxisRaw("Vertical");
            movement = new Vector3(datoHorizontal * speed, mainRigyBody.velocity.y, datoVertical * speed);
            mainRigyBody.velocity = movement;
        
    }
    //Estamos comprobando el contacto entre collaider y onTriggers, no hemos especificado ninguno
    private void OnTriggerEnter(Collider other)
    {  
        //Comparo el tag del objeto contra el que he colisionado, para desactivarlo solo en el caso de que sea un pickup
        if (other.gameObject.CompareTag("PickUp"))
        {
            // Si es un PickUp, lo desactivo.
            other.gameObject.SetActive(false);
            score = score + 1;
            //SetCountText();
            //score++;
            score += other.gameObject.GetComponent<RotationCube>().valuePoint;
            scoreText.text = "Score: " + score;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            mainRigyBody.AddForce(new Vector3(10,0,10), ForceMode.Impulse);
            //Debug.Log(mainRigyBody);
            //Control = false;
        }
    }
    
    /*void SetCountText()
    {
        //countText.text = "Score: " + score.ToString();
        winText.text = score.ToString();
        
    }*/
}

