using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementRoad : MonoBehaviour
{
    public float speed = -5f;
    private Rigidbody2D rb;  

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

        
        if (rb != null)
        {
            rb.gravityScale = 0;  
        }
    }

    void Update()
    {
        
        if (rb != null)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);  
        }
    }
}

