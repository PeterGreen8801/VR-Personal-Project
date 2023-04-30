using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{
    public int score = 0;

    public bool timerIsRunning = false;

    public float currentTime = 0f;
    public float startingTime = 30f;

    [SerializeField]
    TextMeshProUGUI countdownText;
    void Start()
    {
        currentTime = startingTime;
    }


    void Update()
    {
        if (timerIsRunning)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
            if (currentTime < 5)
            {
                countdownText.color = Color.red;
            }
            if (currentTime <= 0)
            {
                currentTime = 0;
            }
        }
    }

    //Start Timer, countdown from 30 seconds
    //Display an order, just complete burger at first
    //If correct order within time, add points

    public void startTimer()
    {
        timerIsRunning = true;
    }
}
