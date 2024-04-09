using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab; // Assign bullet prefab in the inspector

    // Update is called once per frame
    void Update()
    {
        // Check for mouse input
        if (Input.GetMouseButtonDown(0)) // Assuming left mouse button is used for shooting
        {
            // Get mouse position in world coordinates
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Ensure z position is set to 0 for 2D shooting

            // Calculate direction towards mouse position
            Vector3 direction = (mousePosition - transform.position).normalized;

            // Instantiate bullet at the current position of the shooter
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // Apply velocity to the bullet in the direction of the mouse cursor
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = direction * GetBulletSpeed();
        }
    }

    // Method to calculate bullet speed
    private float GetBulletSpeed()
    {
        // You can adjust the bullet speed here or use any logic to determine the speed
        return 10f; // Default speed is set to 10 units per second
    }
}
