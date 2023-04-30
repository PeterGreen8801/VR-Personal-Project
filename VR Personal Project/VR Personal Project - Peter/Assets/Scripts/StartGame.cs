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


    public bool correctOrder = false;
    public bool orderOne = false;
    public bool justLettuce = false;
    public bool justTomato = false;
    public bool justCheese = false;
    public bool lettuceTomato = false;
    public bool lettuceCheese = false;
    public bool tomatoCheese = false;

    public int currentOrder = 1;
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
        randomOrder();
    }

    public void randomOrder()
    {
        int randomNumber = Random.Range(1, 9);
        Debug.Log("Random number is " + randomNumber);
        currentOrder = randomNumber;
        Debug.Log("Current order is " + currentOrder);
    }

    public int getCurrentOrder()
    {
        return currentOrder;
    }

    public void setCurrentOrder(int orderToSet)
    {
        currentOrder = orderToSet;
    }
}
