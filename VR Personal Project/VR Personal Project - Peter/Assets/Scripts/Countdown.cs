using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 5f;

    public bool timerIsRunning = false;

    public int holderPicker = 0;

    [SerializeField]
    TextMeshProUGUI countdownText;

    [SerializeField]
    GameObject textHolder;

    [SerializeField]
    GameObject textHolder2;

    void Start()
    {
        currentTime = startingTime;
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
        if (timerIsRunning)
        {
            if (holderPicker == 1)
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
    }

    public void startCountdown()
    {
        textHolder.SetActive(true);
        currentTime = currentTime - 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            textHolder.SetActive(false);
        }
    }

    public void startTimer(int textHolderToUse)
    {
        timerIsRunning = true;
        holderPicker = textHolderToUse;
    }
}
