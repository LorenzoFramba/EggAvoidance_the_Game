
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
  
    public Rigidbody Rb;
    public float backwardForce = 500f;

    // Update is called once per frame
    void Update()
    {

            Rb.AddForce(0, 0, -backwardForce * Time.deltaTime);
    } 
}