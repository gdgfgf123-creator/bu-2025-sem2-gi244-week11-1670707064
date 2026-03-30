using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    public int waveNumber = 1;

    void Start()
    {
        SpawnWave();
    }

    void Update()
    {
        // ถ้าไม่มี enemy เหลือ ? wave ต่อไป
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            waveNumber++;
            SpawnWave();
        }
    }

    void SpawnWave()
    {
        Debug.Log("Wave: " + waveNumber);

        for (int i = 0; i < waveNumber; i++)
        {
            RandomSpawn();
        }
    }

    void RandomSpawn()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[index];

        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}