using UnityEngine;

public class check : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter with " + collision.gameObject.name);
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter with " + other.gameObject.name);
    }
}
