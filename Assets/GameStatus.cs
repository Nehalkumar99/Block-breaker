using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
   [Range(0.5f,5f)] [SerializeField] float gameSpeed = 1f;
    // Update is called once per 
    [SerializeField] int currentScore;
    [SerializeField] int scorePoints;
    [SerializeField] TextMeshProUGUI scoreText;
    private void Start()
    {
        gameSpeed = 1f;
    }
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void addScore()
    {
        currentScore += scorePoints;
        scoreText.text ="SCORE\n"+ currentScore.ToString();
    }
}
