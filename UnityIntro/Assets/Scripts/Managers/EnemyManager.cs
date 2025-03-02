using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private List<Enemy> enemies;

    public void SpawnRandomEnemy()
    {
        int randomIndex = Random.Range(0, enemies.Count);
        Enemy selectedEnemy = enemies[randomIndex];

        Vector3 spawnPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));

        Instantiate(selectedEnemy, spawnPosition, Quaternion.identity);
    }

}
