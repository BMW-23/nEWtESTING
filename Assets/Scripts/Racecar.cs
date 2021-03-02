using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racecar : MonoBehaviour
{
   
    public float thrust = 1.0f;
    public Rigidbody2D rb;
    public float rotationSpeed = 1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed);
       
        
        rb.AddForce(transform.up * thrust * -Input.GetAxis("Vertical"));
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("Enemy");
            Destroy(other.gameObject);
        }
        
    }
}

