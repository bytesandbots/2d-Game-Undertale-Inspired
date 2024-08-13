using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyEncounter : MonoBehaviour
{
    public EnemyTypeEncountered enemyTypeEncountered;
    public PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = GameObject.Find("PlayerManager").GetComponent<PlayerStats>();

        if (enemyTypeEncountered == null)
        {
            Debug.LogError("EnemyTypeEncountered is not assigned in the inspector.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Optionally, add any update logic here
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has an EnemyType component
        EnemyType enemyType = collision.gameObject.GetComponent<EnemyType>();

        if (enemyType != null && enemyTypeEncountered != null)
        {
            // Set the EncounterType and print it
            enemyTypeEncountered.encounterType = enemyType.encounterType;
            Debug.Log(enemyType.encounterType);

            Destroy(collision.gameObject);

            playerStats.lastOverworldXCords = transform.position.x;
            playerStats.lastOverworldYCords = transform.position.y;

            SceneManager.LoadScene(enemyTypeEncountered.encounterType.ToString());
        }
        else if (enemyType == null)
        {
            Debug.Log("Collided object does not have an EnemyType component.");
        }
    }
}
