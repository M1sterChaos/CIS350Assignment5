/*
 * (Austin Buck)
 * (Assignment 5)
 * (Controls the win text)
 */
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text WinText;

    public GameObject wto;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ScoreModifier.score >= 10 && collision.gameObject.tag == "Player")
        {
            wto.SetActive(true);
            WinText.text = "You've Won!";
        }
    }
}
