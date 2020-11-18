using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScoreOnGameOver : MonoBehaviour
{
    [SerializeField] Text scoreText;

    private void Update()
    {
        scoreText.text = "Score: " + FindObjectOfType<GetScore>().getScore();
    }
}
