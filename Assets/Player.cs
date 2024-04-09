using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Check if the player GameObject is tagged correctly
        if (!gameObject.CompareTag("Player"))
        {
            Debug.LogWarning("Player GameObject is not tagged as 'Player'. Please ensure it is tagged correctly.");
            // You might want to tag it programmatically to ensure it's tagged correctly:
            gameObject.tag = "Player";
        }
    }

    // Method to handle player death
    public void KillPlayer()
    {
        // You can implement death behavior here, such as showing a game over screen, resetting the level, etc.
        Debug.Log("Player has been killed!");
        // For example:
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
