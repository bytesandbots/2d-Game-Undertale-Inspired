using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCounter : MonoBehaviour
{
    public PlayerStats playerStats;
    public float startingEnemies;
    public float currentEnemies;


    private void Awake()
    {
        playerStats = GameObject.Find("PlayerManager").GetComponent<PlayerStats>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startingEnemies <= 0)
        {
            playerStats.winBattle();
        }
    }
}
