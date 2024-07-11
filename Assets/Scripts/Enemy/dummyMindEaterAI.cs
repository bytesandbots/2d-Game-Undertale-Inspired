using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyMindEaterAI : MonoBehaviour
{
    [Header("Class References")]
    public BattleManager battleManager;
    public PlayerStats playerHealth;

    [Header("Move Towards Player")]
    public Transform player;           // Reference to the player's transform
    public float speed = 2.0f;         // Movement speed of the enemy
    public float targetDistance = 3.0f; // Desired distance from the player
    public float tolerance = 0.5f;     // Tolerance range to avoid shakiness
    public bool moveTowards = true;    // Flag to control movement

    [Header("Attack")]

    public float maxAttackCooldown;
    public float attackCooldown;
    public float specielDamageDistance = 3.0f;
    public int specielDamage = 3;
    public float damageRange = 3.0f;
    public int damage = 3;

    void Update()
    {
        attackCooldown -= Time.deltaTime * battleManager.battleTime;


        if (moveTowards)
        {
            // Calculate the distance and direction vector from the enemy to the player
            Vector2 direction = player.position - transform.position;
            float distance = direction.magnitude;

            // Normalize the direction to get a unit vector
            direction.Normalize();

            // Determine the movement direction based on the distance to the player
            Vector2 movement = Vector2.zero;
            if (distance > targetDistance + tolerance)
            {
                // Move towards the player
                movement = direction * speed * battleManager.battleTime;
            }
            else if (distance < targetDistance - tolerance)
            {
                // Move away from the player
                movement = -direction * speed * battleManager.battleTime;
            }

            if(distance <= specielDamageDistance && attackCooldown <= 0)
            {
                playerHealth.DamagePlayer(specielDamage);
                attackCooldown = maxAttackCooldown;
            }

            else if(distance <= damageRange && attackCooldown <= 0)
            {
                playerHealth.DamagePlayer(damage);
                attackCooldown = maxAttackCooldown;
            }

            // Move the enemy
            transform.position += (Vector3)movement * Time.deltaTime  * battleManager.battleTime;
        }
    }
}
