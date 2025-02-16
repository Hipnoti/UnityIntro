using UnityEngine;

public class MovingObjectWithInput : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float rotationSpeed = 10f;

    public bool stopOnShoot = true;
    
    public Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        Vector3 movementVector = Vector3.zero;
        Vector3 rotationVector = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movementVector += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementVector += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotationVector += Vector3.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotationVector += Vector3.up;
        }
        
        Vector3 localMovement = transform.TransformDirection(movementVector);
        rigidbody.AddForce(localMovement * movementSpeed);
        rigidbody.AddTorque(rotationVector * rotationSpeed);
        // rigidbody.linearVelocity = movementVector * movementSpeed;
        // rigidbody.angularVelocity = rotationVector * rotationSpeed;
    }


    public void StopMoving()
    {
        movementSpeed = 0;
        rotationSpeed = 0;
    }
}
