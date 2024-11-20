using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX: MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22; 
    private float spawnLimitXRight = 7;
    private float spawnPosY= 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = 6.0f;
    void Start()
    {
    // Remove From Start--> InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval); 
        SpawnRandomBall();
    }
    // Spawn random ball at random position at top of play area
    void SpawnRandomBall()
{
        //spawn Interval for ball prefabs falling

        Invoke("SpawnRandomBall", Random.Range(3.0f, 5.0f));

        //Index for BallPrefabs 

        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position 

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instantiate ball at random spawn Location 

        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs [ballIndex].transform.rotation);
    
    }

}
    


