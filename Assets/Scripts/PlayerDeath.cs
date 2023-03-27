using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject deathEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        // Check if the colliding object is an enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Spawn a death effect at the player's position
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Debug.Log("You Died!");
            // Destroy the player
            Destroy(gameObject);
            
        }
    }
}
