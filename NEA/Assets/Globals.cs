using UnityEngine;

public static class Globals
{
    public static Difficulty currentDifficulty = Difficulty.Rookie;
    //public static Vector3[] spawnPoints { get; private set; }
    public static Vector3[] spawnPoints = new Vector3[] 
    {
        new Vector3(0f, 1f, 0f),
        new Vector3(1.2f, 1f, 0f),
        new Vector3(1.2f, 1f, 1.2f),
        new Vector3(0f, 1f, 1.2f),
        new Vector3(-1.2f, 1f, 0f)
    };

    public class Difficulty
    {
        public string name;
        public int zombieBaseHealth;
        public int zombieBaseSpeed;
        public int zombieHealthIncrement;

        Difficulty(string dName, int zBH, int zBS, int zHI)
        {
            name = dName;
            zombieBaseHealth = zBH;
            zombieBaseSpeed = zBS;
            zombieHealthIncrement = zHI;
        }
        public static Difficulty Rookie = new Difficulty("Rookie", 1, 2, 10);
        public static Difficulty Intermediate = new Difficulty("Intermediate", 70, 4, 15);
        public static Difficulty ProZombieKiller = new Difficulty("Pro Zombie Killer", 100, 8, 18);
        public static Difficulty GodMode = new Difficulty("God Mode", 150, 16, 20);
    }
}
