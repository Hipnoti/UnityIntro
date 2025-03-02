using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int currentHP = 100;
    public MeshRenderer graphicsMeshRenderer;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered with  " + other.gameObject.name);
        bool reachedLevelEnd = other.CompareTag("LevelEndTrigger");
        bool collectedPowerUp = other.CompareTag("PowerUp");
        if (reachedLevelEnd)
            SceneManager.LoadScene("Credits Scene");
        else if (collectedPowerUp)
        {
            currentHP += 10;
            scoreManager.AddScore(10);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision with  " + other.gameObject.name);
        // MeshRenderer meshRenderer = other.gameObject.GetComponent<MeshRenderer>();
        // meshRenderer.material.color = Color.red;
    }
}
