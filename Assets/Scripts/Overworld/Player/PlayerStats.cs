using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int defense;
    public int level;
    public int xp;
    public int health;
    public int maxHealth;

    public float lastOverworldXCords;
    public float lastOverworldYCords;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (health >= maxHealth)
        {
            health = maxHealth;
        }

        if (health <= 0)
        {

            SceneManager.LoadScene("deathScreen");
            DamagePlayer(-1000000000);
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            DamagePlayer(3);
        }
    }

    public void DamagePlayer(int damage)
    {
        health -= damage -= defense -= 1 / 100;
    }

    public void winBattle()
    {
            
    }
}
