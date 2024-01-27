using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallBehaviour : MonoBehaviour
{
    public float force, fluctuation;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            var Direction = transform.position.x - collision.transform.position.x;
            if (Direction < 0) return; else fluctuation *= -1;
            rb.velocity = new Vector2(Direction * fluctuation, force);  
        }
    }
}