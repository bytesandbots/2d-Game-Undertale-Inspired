using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    public PlayerStats playerStats;
    public TMP_Text healthText;
    public Image healthBar;
    private void Awake()
    {
        playerStats = GameObject.Find("PlayerManager").GetComponent<PlayerStats>();
    }

    void Update()
    {
        healthBar.fillAmount = (float)playerStats.health / (float)playerStats.maxHealth;

        healthText.text = playerStats.health.ToString() + "/" + playerStats.maxHealth.ToString();
    }
}
