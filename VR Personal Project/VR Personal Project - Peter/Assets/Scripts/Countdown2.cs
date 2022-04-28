using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown2 : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 5f;

    public float currentTime2 = 0f;


    public bool timerIsRunning = false;

    public bool timer2IsRunning = false;

    public int holderPicker = 0;

    [SerializeField]
    TextMeshProUGUI countdownText;

    [SerializeField]
    TextMeshProUGUI countdownText2;

    [SerializeField]
    GameObject textHolder;

    [SerializeField]
    GameObject textHolder2;

    void Start()
    {
        currentTime = startingTime;
        currentTime2 = startingTime;
    }

    /*
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
    */

    void Update()
    {
        if (timer2IsRunning)
        {
            if (holderPicker == 2)
            {
                textHolder2.SetActive(true);
                currentTime2 = currentTime2 - 1 * Time.deltaTime;
                countdownText2.text = currentTime2.ToString("0");

                if (currentTime2 <= 0)
                {
                    currentTime2 = startingTime;
                    textHolder2.SetActive(false);
                    timer2IsRunning = false;
                }
            }
        }
    }



    public void startTimer(int textHolderToUse)
    {
        if (textHolderToUse == 1)
        {
            timerIsRunning = true;
            holderPicker = textHolderToUse;
        }
        if (textHolderToUse == 2)
        {
            timer2IsRunning = true;
            holderPicker = textHolderToUse;
        }


    }
}
