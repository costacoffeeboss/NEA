using UnityEngine;
using UnityEngine.AI;

public class ZombieBehaviour : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    RoundController roundController;

    Transform player;
    int health;
    private void Start()
    {
        roundController = GameObject.Find("Round Controller").GetComponent<RoundController>();
        health = Globals.currentDifficulty.zombieBaseHealth;
        navMeshAgent.speed = Globals.currentDifficulty.zombieBaseSpeed;
        player = GameObject.Find("Main Camera").transform;
    }

    // Update is called once per frsssssame
    void Update()
    {
        navMeshAgent.SetDestination(player.position);
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            roundController.zombiesAlive -= 1;
            Destroy(transform.gameObject);
        }
    }
}
