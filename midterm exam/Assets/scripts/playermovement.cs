using UnityEngine;

public class playermovement : MonoBehaviour {
    /// reference to Rigidbody for Rb
    public Rigidbody Rb;

    /// add force forward to make the car run
    public float forwardForce = 2000f;
    public float sideForce = 100;

    // Update is called once per frame
    void FixedUpdate()

    /// add force side ways
    {
        Rb.AddForce(0,0,forwardForce * Time.deltaTime);
        
        if (Input.GetKey("d"))
    {
        Rb.AddForce(100 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if (Input.GetKey("a"))
    {
        Rb.AddForce(-100 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        
    }

    }
}
