using UnityEngine;

public class MovingObjectWithInput : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float rotationSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
        if (movementVector != Vector3.zero || rotationVector != Vector3.zero)
        {
            if (movementVector != Vector3.zero)
                transform.Translate(movementVector * (movementSpeed * Time.deltaTime));
            if (rotationVector != Vector3.zero)
                transform.Rotate(rotationVector * (rotationSpeed * Time.deltaTime));
        }
    }
}
