using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] meteorPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        float startDelay = 2.0f;
        Invoke("SpawnMeteor", startDelay);
    }

    void SpawnMeteor()
    {
        int spawnRangeZ = 17;
        int spawnPosX = 1;
        int spawnMinY = 25;
        int spawnMaxY = 35;
        int meteorIndex = Random.Range(0, meteorPrefabs.Length);

        // spawn meteor in random location
        Vector3 spawnLocation = new Vector3(spawnPosX, Random.Range(spawnMinY, spawnMaxY), Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(meteorPrefabs[meteorIndex], spawnLocation, meteorPrefabs[meteorIndex].transform.rotation);

        // invoke again after random time interval
        float minSpawnTime = 1.0f;
        float maxSpawnTime = 2.5f;
        float spawnInterval = Random.Range(minSpawnTime, maxSpawnTime);
        Invoke("SpawnMeteor", spawnInterval);
    }
}
