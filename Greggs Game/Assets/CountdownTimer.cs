﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countdownText;
    
    void Awake()
    {
        currentTime = startingTime;
    }

 
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <=0)
        {
            currentTime = 0;
        }
    }
    void VictoryorFail()
    {
        if(currentTime == 0)
        {

        }
    }
}
