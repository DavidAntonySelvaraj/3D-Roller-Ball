using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private Enemy enemyPrefab;

    private Enemy spawnedEnemy;

    private Vector3 spawnPos;

    [SerializeField]
    private float minSpawnPos=-30f,maxSpawnPos=30f;

    [SerializeField]
    private float minYPos=1f,maxYPos=5f;

    private Transform playerTarget;

    [SerializeField]
    private float minSpwanTime = 3f,maxSpwanTime=6f;

    private float spawnTimer;


    private void Awake()
    {
        playerTarget = GameObject.FindWithTag(TagManager.PLAYER_TAG).transform;
    }

    private void Update()
    {
        CheckToSpawnTheEnemy();
    }

    void SpawnEnemy()
    {
        spawnPos = new Vector3(Random.Range(minSpawnPos, maxSpawnPos),Random.Range(minYPos,maxYPos),Random.Range(minSpawnPos,maxSpawnPos));

        spawnedEnemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

        spawnedEnemy.SetTarget(playerTarget);
    }

    void CheckToSpawnTheEnemy()
    {
        if (Time.time > spawnTimer)
        {
            spawnTimer = Time.time + Random.Range(minSpwanTime, maxSpwanTime);
            SpawnEnemy();
        }
    }
}//class














































