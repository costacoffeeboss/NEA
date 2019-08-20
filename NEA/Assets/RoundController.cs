using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    int roundNumber;
    public int zombiesAlive;
    public GameObject zombiePrefab;
    public Transform zombieManager;



    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Zombies alive:" + zombiesAlive.ToString());
        if (zombiesAlive == 0)
        {
            roundNumber += 1;
            zombiesAlive = GetZombieCountFromRoundNumber(roundNumber);
            MakeZombies(zombiesAlive);
        }
    }
    
    int GetZombieCountFromRoundNumber(int rNumber)
    {
        int zNumber = 5 * rNumber;
        return zNumber;
    }

    void MakeZombies(int numberOf)
    {
        while (numberOf >= Globals.spawnPoints.Length)
        {
            numberOf -= Globals.spawnPoints.Length;
            foreach (Vector3 spawnPoint in Globals.spawnPoints)
            {
                Instantiate(zombiePrefab, spawnPoint, Quaternion.identity, zombieManager);
            }
        }
        for (int i=0; i < numberOf; i += 1)
        {
            Instantiate(zombiePrefab, Globals.spawnPoints[i], Quaternion.identity, zombieManager);
        }
        StartCoroutine(TimeDelay(5f));
    }

    IEnumerator TimeDelay(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
