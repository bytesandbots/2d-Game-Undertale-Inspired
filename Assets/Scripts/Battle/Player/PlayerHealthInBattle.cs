using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealthInBattle : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public TMP_Text healthText;
    public Image healthBar;
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(health >= maxHealth)
        {
            health = maxHealth;
        }
        //healthBar.fillAmount = (float)health/(float)maxHealth;

        //healthText.text = health.ToString() + "/" + maxHealth.ToString();

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            DamagePlayer(3);
        }

        if(health <= 0)
        {
            SceneManager.LoadScene("deathScreen");
        }
    }


    public void DamagePlayer(int damage)
    {
        health -= damage;
    }
}
