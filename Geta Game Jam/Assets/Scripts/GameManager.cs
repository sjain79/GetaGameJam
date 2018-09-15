using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public static bool gameStarted;
    public static bool gameOver;
    public static int score;

    [SerializeField]
    public GameObject inGameCanvas,endGameCanvas;

    private void OnEnable()
    {
        
    }

    private void Awake()
    {
        gameOver = false;
        score = 0;
    }

    private void Start()
    {
        //GameObject.Find("Ball").GetComponent<Rigidbody2D>().AddForce(  new Vector2(0, -7),ForceMode2D.Impulse);
    }

    private void Update()
    {
        if (gameOver)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Scpre!!");
            score++;
        }
        
    }

    public void GameIsOver()
    {
        Time.timeScale = 0;
        inGameCanvas.SetActive(false);
        endGameCanvas.SetActive(true);
    }

}
