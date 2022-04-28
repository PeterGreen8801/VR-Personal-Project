using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 5f;

    [SerializeField]
    TextMeshProUGUI countdownText;

    [SerializeField]
    GameObject textHolder;

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

    void startCountdown()
    {
        textHolder.SetActive(true);
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
