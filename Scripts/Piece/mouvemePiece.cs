using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvemePiece : MonoBehaviour
{
    public float speed = -80f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
       
    }

    public void AddSpeed()
    {
        speed += -5f;
        Debug.LogWarning(speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ScoreManager>().AddPoints(5);
        }

    }
}



