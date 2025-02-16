using UnityEngine;

public class ShootMechanic : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;

    public KeyCode fireKey = KeyCode.Mouse0;
    
    public MovingObjectWithInput movingObjectComponent;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.transform.rotation);
            if (movingObjectComponent.stopOnShoot == true)
                movingObjectComponent.StopMoving();
        }
    }
}
