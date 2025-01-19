using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public bool printToConsoleOnStart = false;
    public float xMovementSpeed = 10;
    public float yMovementSpeed = 10;
    public float zMovementSpeed = 10;

    private int damageOnCollision = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(printToConsoleOnStart)
            Debug.Log("MovingObject Start!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xMovementSpeed * Time.deltaTime, yMovementSpeed * Time.deltaTime, zMovementSpeed * Time.deltaTime);
    }
}
