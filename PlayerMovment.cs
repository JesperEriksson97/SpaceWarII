using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float leftForce = -2000f;
    public float rightForce = 2000f;

    // FixedUpdate is used when handling physics
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) {
            rb.AddForce(rightForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")) {
            rb.AddForce(leftForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -4f)
        {
            FindObjectOfType<Gm>().gameOver();
        }
    }
}
