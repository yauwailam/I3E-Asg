/*
 * Author: Elyas Chua-Aziz
 * Date: 06/05/2024
 * Description: 
 * The door that opens when the player is near it and presses the interact button.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    public TextMeshProUGUI displaytext;
    bool opened = false;
    public bool locked = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !opened)
        {
            //Debug.Log("fbnkjsdn");
            //openDoor();

            other.gameObject.GetComponent<Player>().UpdateDoor(this);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Check if the obejct exiting the trigger has the "Player" tag
        if (other.gameObject.tag == "Player")
        {
            // If it is the player, update the player that there is no door
            other.gameObject.GetComponent<Player>().UpdateDoor(null);
            displaytext.text = "";

        }
    }
    public void OpenDoor()
    {
        if (!locked)
        {
            if (!opened)
            {
                Vector3 newRotation = transform.eulerAngles;

                // Add 90 degrees to the y axis rotation
                newRotation.y -= 90f;

                // Assign the new rotation to the transform
                transform.eulerAngles = newRotation;
                opened = true;
            }
            else
            {
                {
                    Vector3 newRotation = transform.eulerAngles;

                    // Add 90 degrees to the x axis rotation
                    newRotation.y += 90f;

                    // Assign the new rotation to the transform
                    transform.eulerAngles = newRotation;
                    opened = false;
                }
            }
        }
        else
        {
            displaytext.text = "Keycard must be found first.";
        }
    }
    public void SetLock(bool lockStatus)
    {
        // Assign the lockStatus value to the locked bool.
        locked = lockStatus;
    }

}
