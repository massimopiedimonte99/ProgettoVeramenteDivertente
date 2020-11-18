using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetScore : MonoBehaviour
{
    public ScoreBoard sb;

    void Start()
    {
        sb = FindObjectOfType<ScoreBoard>();
    }

    void Update()
    {
    }

    public int getScore()
    {
        return sb.getScore();
    }

    public void setScore(int score)
    {
        sb.setScore(score);
    }
}
