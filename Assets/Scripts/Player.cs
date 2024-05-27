/*
 * Author: Elyas Chua-Aziz
 * Date: 06/05/2024
 * Description: 
 * Contains functions related to the Player such as increasing score.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int currentScore = 0;
    Door currentDoor;
     Collectible currentCollectible;
    public void UpdateDoor(Door newDoor)
    {
        currentDoor = newDoor;
    }
    public void UpdateCollectible(Collectible newCollectible)
    {
        currentCollectible = newCollectible;
    }
    public void IncreaseScore(int scoreToAdd)
    {
        // Increase the score of the player by scoreToAdd
        currentScore += scoreToAdd;

        //scoreText.text = "Score: " + currentScore.ToString();
    }
    void OnInteract()
    {
        // This is "null check"
        if(currentDoor != null)
        {
            currentDoor.OpenDoor();
            currentDoor = null;
        }

        //if(currentCollectible != null)
        //{
          //  Debug.Log("call");
            //IncreaseScore(currentCollectible.myScore);
            //currentCollectible.Collected();
        //} 
        //} 
    }
    void Update()
    {
        scoreText.text = $"Cash collected : {currentScore}";

        if (currentScore == 25)
        {
            scoreText.text = "You have won!";
        }

    
    }

}
