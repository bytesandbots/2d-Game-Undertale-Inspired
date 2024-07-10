using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyEnemyAI : MonoBehaviour
{
    public Transform player;           // Reference to the player's transform
    public float speed = 2.0f;         // Movement speed of the enemy
    public float targetDistance = 3.0f; // Desired distance from the player
    public float tolerance = 0.5f;     // Tolerance range to avoid shakiness
    public bool moveTowards = true;    // Flag to control movement

    void Update()
    {
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
                movement = direction * speed;
            }
            else if (distance < targetDistance - tolerance)
            {
                // Move away from the player
                movement = -direction * speed;
            }

            // Move the enemy
            transform.position += (Vector3)movement * Time.deltaTime;
        }
    }
}
