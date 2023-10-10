using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    public Text scoreText;
    public Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            livesText.text = "Game Over";
            lives = 0;
        }
        else
        {
            livesText.text = "Lives: " + lives;
        }
    }
    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
    }

}
