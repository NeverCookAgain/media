/*
*   This script serves as a timer for the game. It changes the UI text and sends a message when the timer expires.
* 
*   Programmer: Christian Toney (https://github.com/Christian-Toney)
*   Designer: Christian Toney (https://github.com/Christian-Toney)
*/

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public bool isActive = false;
    public float secondsRemaining = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {

        if (isActive && secondsRemaining > 0) 
        {

            // Convert the seconds to "-:--" format.
            secondsRemaining = Math.Max(secondsRemaining - Time.deltaTime, 0);

            int minutes = (int) Math.Floor(secondsRemaining / 60);
            int seconds = (int) Math.Floor(secondsRemaining - minutes * 60);

            gameObject.GetComponent<TextMeshProUGUI>().text = minutes + ":" + (seconds < 10 ? "0" : "") + seconds;

            // Send a message if the timer expired.
            if (secondsRemaining == 0) {

                isActive = false;
                BroadcastMessage("OnTimerExpired");

            }

        }

    }

}
