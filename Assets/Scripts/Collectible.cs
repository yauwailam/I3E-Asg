/*
 * Author: Elyas Chua-Aziz
 * Date: 06/05/2024
 * Description: 
 * The Collectible will destroy itself after being collided with.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    
    /// <summary>
    /// The score value that this collectible is worth.
    /// </summary>
    public int myScore = 1;
    public TextMeshProUGUI displaytext;

    /// <summary>
    /// Performs actions related to collection of the collectible
    /// </summary>
    public virtual void Collected(GameObject other)
    {
        // Destroy the attached GameObject
        Destroy(gameObject);

    }

    /// <summary>
    /// Callback function for when a collision occurs
    /// </summary>
    /// <param name="collision">Collision event data</param>
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that
        // touched me has a 'Player' tag
        if(other.gameObject.tag == "Player")
        {
            // Look for the "Player" component on the GameObject that collided with me.
            // Update the player that I am the current collectible.
            Debug.Log("enter trigger");
            other.gameObject.GetComponent<Player>().UpdateCollectible(this);
            Collected(other.gameObject);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object that
        // stopped touching me has a 'Player' tag
        if (other.gameObject.tag == "Player")
        {
            // Look for the "Player" component on the GameObject that collided with me.
            // Update the player that there is no current collectible.
            other.gameObject.GetComponent<Player>().UpdateCollectible(null);
        }
    }


}
