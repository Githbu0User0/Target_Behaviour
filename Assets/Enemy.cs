using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    // Speed at which the enemy moves
    public float speed = 5f;

    // Reference to the player object
    private Transform player;

    // Toggle to enable chasing behavior
    public bool chasePlayer = true;

    // Start is called before the first frame update
    void Start()
    {
        // Find the player object by tag
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
        else
        {
            Debug.LogWarning("Player object not found! Ensure that a GameObject with the 'Player' tag exists in the scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // If chasing behavior is enabled and player reference is not null
        if (chasePlayer && player != null)
        {
            // Move the enemy towards the player
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    // OnTriggerEnter is called when the enemy collides with another collider
    void OnTriggerEnter(Collider other)
    {
        // Check if the collider is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Get the Player component and call its KillPlayer method
            other.GetComponent<Player>().KillPlayer();
        }
    }
}
