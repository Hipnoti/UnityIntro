using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int currentHP = 100;
    
    private void OnTriggerEnter(Collider other)
    {
        bool reachedLevelEnd = other.CompareTag("LevelEndTrigger");
        bool collectedPowerUp = other.CompareTag("PowerUp");
        if (reachedLevelEnd)
            SceneManager.LoadScene("Credits Scene");
        else if (collectedPowerUp)
        {
            currentHP += 10;
            Destroy(other.gameObject);
        }
    }

    // private void OnCollisionEnter(Collision other)
    // {
    //     MeshRenderer meshRenderer = other.gameObject.GetComponent<MeshRenderer>();
    //     meshRenderer.material.color = Color.red;
    // }
}
