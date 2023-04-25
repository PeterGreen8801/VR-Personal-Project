using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBurger : MonoBehaviour
{

    public float currentTime = 0f;
    public float startingTime = 5f;

    public bool timerIsRunning = false;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            currentTime = currentTime - 1 * Time.deltaTime;
            if (currentTime <= 0)
            {
                currentTime = startingTime;
                timerIsRunning = false;
            }
        }

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lettuce")
        {
            Debug.Log("It hit lettuce!");
        }
        if (other.tag == "Tomato")
        {
            Debug.Log("It hit tomato!");
        }
        if (other.tag == "Cheese")
        {
            Debug.Log("It hit cheese");
        }
        if (other.tag == "Top Bun")
        {
            Debug.Log("It hit top bun");
        }
        if (other.tag == "Bun")
        {
            Debug.Log("It hit bun");
        }
    }

    public void startTimer()
    {
        timerIsRunning = true;
    }
}
