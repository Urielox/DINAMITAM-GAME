using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public int jumpsAvailable;
    int jumpCount;
    Rigidbody rb;

    void Start ()
    {
        jumpCount = jumpsAvailable;
        rb = GetComponent<Rigidbody>();
	}
	
    private void FixedUpdate()
    {
        float horizontalDirection = Input.GetAxis("Horizontal") * speed;

        rb.velocity = new Vector3(horizontalDirection, rb.velocity.y, 0.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(jumpsAvailable != 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + jumpForce, 0.0f);
                jumpsAvailable--;
            }
        }     
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Platform")
        {
            transform.SetParent(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Platform")
        {
            transform.SetParent(null);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        jumpsAvailable = jumpCount;  
    }
}
