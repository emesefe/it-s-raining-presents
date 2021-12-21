using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private GameObject[] targetPrefabs;

    private float spawnPosY = 10f;
    private float spawnPosZ = 0f;
    private float spawnHorizontalLim = 7f;

    private float startAfterTime = 1f;
    private float repeatRate = 2f;
    
    
    // Start is called before the first frame update
    void Update()
    {
        InvokeRepeating("RandomSpawnPosition", startAfterTime, repeatRate);
    }

    public Vector3 RandomSpawnPosition()
    {
        float randomSpawnPosX = Random.Range(-spawnHorizontalLim, spawnHorizontalLim);
        return new Vector3(randomSpawnPosX, spawnPosY, spawnPosZ);
    }

    public void SpawnRandomObject()
    {
        int randomIndex = Random.Range(0, targetPrefabs.Length);
        Instantiate(targetPrefabs[1],
            RandomSpawnPosition(),
            targetPrefabs[1].transform.rotation);
    }
}
