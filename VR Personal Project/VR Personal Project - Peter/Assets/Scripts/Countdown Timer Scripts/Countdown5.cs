using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown5 : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 5f;

    public bool timerIsRunning = false;

    //public int holderPicker = 0;

    [SerializeField]
    TextMeshProUGUI countdownText;

    [SerializeField]
    GameObject textHolder;

    void Start()
    {
        currentTime = startingTime;
    }


    void Update()
    {
        if (timerIsRunning)
        {
            textHolder.SetActive(true);
            currentTime = currentTime - 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = startingTime;
                textHolder.SetActive(false);
                timerIsRunning = false;
            }
        }

    }


    /*
    public void startTime(int textHolderToUse)
    {
        if (textHolderToUse == 1)
        {
            timerIsRunning = true;
            //holderPicker = textHolderToUse;
        }

    }
    */

    public void startTimer()
    {
        timerIsRunning = true;
    }
}
