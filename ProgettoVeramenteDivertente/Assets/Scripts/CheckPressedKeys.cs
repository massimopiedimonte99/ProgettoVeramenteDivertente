using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPressedKeys : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            FindObjectOfType<ScoreBoard>().setScore(0);
            FindObjectOfType<ScoreBoard>().resetLives();
            SceneManager.LoadScene(0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
