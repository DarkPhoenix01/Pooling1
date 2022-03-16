using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Enemy;
    public int timeToSpawn;
    public int enemyType;
    public Transform SpawnPosition;
    

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, timeToSpawn);
        InvokeRepeating("SpawnPowerUp", 0, 20);
    }

    private void Update() {
        
    }

    public void SpawnEnemy()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-30.0f,30.0f),SpawnPosition.position.y, SpawnPosition.position.z);

        GameObject enemy = PoolManager.instance.GetPooledObject(1);
        enemy.transform.position = SpawnPos;
        enemy.SetActive(true);
    }

    public void SpawnPowerUp()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-30.0f,30.0f),SpawnPosition.position.y, SpawnPosition.position.z);

        GameObject power = PoolManager.instance.GetPooledObject(2);
        power.transform.position = SpawnPos;
        power.SetActive(true);
    }


}
