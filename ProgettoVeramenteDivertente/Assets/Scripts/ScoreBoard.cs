using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] Text livesText;
    [SerializeField] Text scoreText;
    private int lives = 3;
    private int score = 0;

    void Start()
    {
        SetLivesText();
        SetScoreText();


        livesText.text = "Lives: " + lives.ToString();
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        if (!livesText) Invoke("SetLivesText", 0f);
        if (!livesText) Invoke("SetScoreText", 0f);
    }

    private void SetLivesText()
    {
        if (GameObject.Find("Lives") != null) livesText = GameObject.Find("Lives").GetComponent<Text>();
    }

    private void SetScoreText()
    {
        if (GameObject.Find("Score") != null) scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    public int getScore()
    {
        return score;
    }

    public void setScore(int score)
    {
        this.score = score;
    }

    public void resetLives()
    {
        lives = 3;
    }

    public void DecraseOneLife()
    {
        lives--;
        livesText.text = "Lives: " + lives.ToString();
    }

    public void UpdateScore()
    {
        score += Random.Range(1,4);
        scoreText.text = "Score: " + score.ToString();
    }
}
