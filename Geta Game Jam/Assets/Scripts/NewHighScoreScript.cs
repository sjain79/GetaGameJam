using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHighScoreScript : MonoBehaviour
{

    [SerializeField]
    GameObject highScore, newHighScore;

    void Start()
    {
        ShowHighScore();
    }

    private void ShowHighScore()
    {
        if (GameManager.score > PlayerPrefs.GetInt("Highscore", 0))
        {
            newHighScore.SetActive(true);
            highScore.SetActive(false);
            PlayerPrefs.SetInt("Highscore", GameManager.score);
        }
        else
        {
            newHighScore.SetActive(false);
            highScore.SetActive(true);
        }
    }
}
