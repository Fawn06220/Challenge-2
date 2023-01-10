using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //private float startDelay = 1.0f;
    //Nouvelles vars pour spawn delai aleatoire entre 3 et 5 secondes
    private float MinspawnInterval = 3.0f;
    private float MaxspawnInterval = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //on mets l'intervalle en random dans l'invoke repeating
        InvokeRepeating("SpawnRandomBall", MinspawnInterval, Random.Range(MinspawnInterval, MaxspawnInterval));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {

        //On selectionne les balles a spawn
        int randBall = Random.Range(0,ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randBall], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
