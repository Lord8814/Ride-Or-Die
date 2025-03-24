using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float startX = 4.3f; 
    public float yPosition = -6.4f; 
    public float step = 8.0f; 
    private int i = 0; 

    private float currentX; 

    private Animator animator;

    void Start()
    {
        currentX = startX;
        transform.position = new Vector3(currentX, yPosition, transform.position.z);
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow) && i > -1)
        {
            i--; 
            animator.SetTrigger("Gauche");
        }

        
        if (Input.GetKeyDown(KeyCode.RightArrow) && i < 1)
        {
            i++; 
            animator.SetTrigger("Droite");
        }

        
        currentX = startX + (i * step);
        
        transform.position = new Vector3(currentX, yPosition, transform.position.z);
    
    }
}
