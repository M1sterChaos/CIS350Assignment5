/*
 * (Austin Buck)
 * (Assignment 5)
 * (Controls the score)
 */
using UnityEngine;
using UnityEngine.UI;

public class ScoreModifier : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Gems Collected: " + score;

        if(score >= 10)
        {
            scoreText.text = "You collected all the gems! \nGo to the end zone!";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            score++;
        }
    }
}
