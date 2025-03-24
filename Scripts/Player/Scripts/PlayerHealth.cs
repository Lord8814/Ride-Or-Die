using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 1;        
    private int currentHealth;    
    private Animator animator;
    


    void Start()
    {

        animator = GetComponent<Animator>();
        currentHealth = maxHealth; 
        if (maxHealth <= 0)
        {
            Debug.LogWarning("La santé maximale n'est pas configurée correctement !");
            maxHealth = 1; 
        }

    }
    public void Die()
    {
        Debug.Log("Le joueur est mort !");
        
        animator.SetTrigger("Die");

        

        StartCoroutine(DieWithDelay());

    }
    private IEnumerator DieWithDelay()
    {
        yield return new WaitForSeconds(0.8f);  
        Debug.Log("Player died after 5 seconds");
        SceneManager.LoadScene("Menu"); 
    }
}
