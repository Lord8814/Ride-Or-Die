using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementEnemie : MonoBehaviour
{
    public float speed = -50f;

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
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                Debug.LogWarning("Trigger activé");
                playerHealth.Die();
            }
            else
            {
                Debug.LogWarning("Le joueur ne possède pas de composant PlayerHealth.");
            }
        }

    }
}



