using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public int level;
    public int xp;
    public int health;
    public int maxHealth;

    public TMP_Text healthText;
    public Image healthBar;
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
        }

        healthBar.fillAmount = (float)health / (float)maxHealth;

        healthText.text = health.ToString() + "/" + maxHealth.ToString();

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            DamagePlayer(3);
        }
    }

    public void DamagePlayer(int damage)
    {
        health -= damage;
    }
}
