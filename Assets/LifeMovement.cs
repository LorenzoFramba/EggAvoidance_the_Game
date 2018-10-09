
using UnityEngine;

public class LifeMovement : MonoBehaviour {

    public Rigidbody Rb;
    public float backwardForce = 200f;
    // Update is called once per frame
    void Update () {
        Rb.AddForce(0, 0, -backwardForce * Time.deltaTime);
    }
}
