using System.Collections;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [SerializeField]
    GameObject endGameCanvas, inGameCanvas;

    //the variable that gets and stores the game time
    [SerializeField]
    private int time;

    //textmesh component on this gameobject
    TextMeshProUGUI myText;

    private void Awake()
    {
        //get the text mesh compenent on this gameobject
        myText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        //start the coroutine everytime this gameobject is enabled
        StartCoroutine(CountDownTimer());
    }

    IEnumerator CountDownTimer()
    {
        //while time has not reached 0
        while (time > 0)
        {
            //if the game is over then do not count down
            //if (GameManager.gameOver)
            //    continue;

            //wait for second
            yield return new WaitForSeconds(1);
            //subtract from the time
            time--;
            //show the time in the text
            myText.text = "Time Remaining " + time;
        }
        //when the time is done, the game is over
        endGameCanvas.SetActive(true);
        inGameCanvas.SetActive(false);
        GameManager.gameOver = true;

    }
}