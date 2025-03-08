// Purpose: Keep track of the player's score and update the score text on the screen.
using UnityEngine;
using TMPro;


public class ScoreKeep : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static ScoreKeep Instance;
    public int Score = 0;
    public TextMeshProUGUI scoreText;

    
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddScore(int amount)
    {
        Score += amount;
        scoreText.text = "Score: " + Score;
    }
}
