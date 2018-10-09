using UnityEngine;
using System.Collections;
public class playermovement : MonoBehaviour {


    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    public float speed = 25f;
    public float mapwidth = 5f;
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime); // aggiunge 2000 di forza nell'asse delle Z
        /*
        if (Input.GetKey("d")){
            rb.AddForce(sidewayForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }*/
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector3 newPosition = rb.position + Vector3.right * x;
       // newPosition.x = Mathf.Clamp(newPosition.x, -mapwidth, mapwidth);
        rb.MovePosition(newPosition);

        if (rb.position.y < -1f){

            FindObjectOfType<BlockRemover>().IncrementScore(0);
            FindObjectOfType<playercollition>().stecchito();
            FindObjectOfType<gameManager>().EndGame();

        }
           
    }
}
