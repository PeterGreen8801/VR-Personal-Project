using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBurger : MonoBehaviour
{

    public float currentTime = 0f;
    public float startingTime = 3f;

    public bool timerIsRunning = false;

    public bool bunCheck;
    public bool topBunCheck;
    public bool lettuceCheck;
    public bool tomatoCheck;
    public bool cheeseCheck;
    public bool completepattyCheck;

    public bool startChecking;
    public bool correctOrder;


    void Start()
    {
        currentTime = startingTime;
        startChecking = false;
        completepattyCheck = false;
        cheeseCheck = false;
        tomatoCheck = false;
        lettuceCheck = false;
        topBunCheck = false;
        bunCheck = false;
        correctOrder = false;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (completepattyCheck && cheeseCheck && tomatoCheck && lettuceCheck && topBunCheck && bunCheck)
            {
                Debug.Log("All are true at the same time. Order right!");
                correctOrder = true; //THIS is where you can make it so points are added to player's score.
            }
            currentTime = currentTime - 1 * Time.deltaTime;
            if (currentTime <= 0)
            {
                currentTime = startingTime;
                timerIsRunning = false;
                startChecking = false;

                completepattyCheck = false;
                cheeseCheck = false;
                tomatoCheck = false;
                lettuceCheck = false;
                topBunCheck = false;
                bunCheck = false;
            }
        }

        if (correctOrder)
        {
            //Score - add base points + time bonus. Need scoring script, once UI start button is pressed - order ui pops up. Timer starts, 
            //lets say 70 seconds. Just patty-25, + 5 for each additional ingredient. + The amount of seconds left on the order. Can have 
            //a raw score like 64, or divide score by 10 or something to get tip amount like $6.40, so final score is tip money.
        }

    }


    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Complete Burger")
        {
            completepattyCheck = true;
            startChecking = true;
            startTimer();
        }

    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Complete Lettuce")
        {
            if (startChecking)
            {
                lettuceCheck = true;
            }

        }
        if (other.tag == "Complete Tomato")
        {
            if (startChecking)
            {
                tomatoCheck = true;
            }

        }
        if (other.tag == "Complete Cheese")
        {
            if (startChecking)
            {
                cheeseCheck = true;
            }

        }
        if (other.tag == "Top Bun")
        {
            if (startChecking)
            {
                topBunCheck = true;
            }

        }
        if (other.tag == "Bun")
        {
            if (startChecking)
            {
                bunCheck = true;
            }

        }
    }

    public void startTimer()
    {
        timerIsRunning = true;
    }
}
