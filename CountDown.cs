using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{


    public Text CountdownText;
    public int Countdown;
    public ResultGame theresultgame;


    private float timer;

    

    // Use this for initialization
    void Start()
    {




        Time.timeScale = 1;
        Countdown = 60;
        CountdownText.text = "Zbývá " + Countdown.ToString();
    }

    // Update is called once per frame
    void Update()

    {



        timer += Time.deltaTime;
        if (timer > 1f)
        {

            Countdown -= 1;
            //We only need to update the text if the score changed.
            CountdownText.text = "Zbývá " + Countdown.ToString();

            //Reset the timer to 0.
            timer = 0;
        }

        if (Countdown == 0)
        {
            theresultgame.Result();

        }

    }
 
}