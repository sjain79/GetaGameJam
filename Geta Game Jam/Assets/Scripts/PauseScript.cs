using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public void Pause()
    {
        if (!GameManager.gameOver)
            Time.timeScale = 0;
    }

    public void Resume()
    {
        if (!GameManager.gameOver)
            Time.timeScale = 1;
    }
}
