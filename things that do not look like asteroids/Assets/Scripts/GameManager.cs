using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rockPrefab;
    public Transform[] spawnPoints;
    public float SpawnRock = 5f;
    public float InitialSpawnRock = 2f;

private void SpawnRocks()
    {

        for (int i = 0; i < 4; i++)
        {
            Vector3 randomPosition = spawnPoints[Random.Range(0, 3)].position;
            Instantiate(rockPrefab, randomPosition, Quaternion.identity);
        }

    }
    // Start is called before the first frame update
    void Start()
        
    {
        InvokeRepeating("SpawnRocks", InitialSpawnRock, SpawnRock);
    } 
        
}
