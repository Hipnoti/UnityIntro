using Unity.VisualScripting;
using UnityEngine;

public class EnlargeBehaviour : MonoBehaviour
{
    public Animator animator;
    public KeyCode enlargeKey = KeyCode.E;
    public KeyCode delargerKey = KeyCode.D;
    public KeyCode bounceKey = KeyCode.B;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(enlargeKey))
        {
            animator.SetBool("Enlarging", true);
        }
        else
        {
            if (Input.GetKeyDown(delargerKey))
            {
                animator.SetBool("Enlarging", false);
            }
            else
            {
                if (Input.GetKeyDown(bounceKey))
                {
                    animator.SetTrigger("Bounce");
                }
            }
        }
    }
}
