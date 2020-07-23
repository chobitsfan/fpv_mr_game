using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class TimerControll : MonoBehaviour
{
    float timer_f = 0f;
    // Start is called before the first frame update

    Boolean IsRunning = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRunning)
        {
            timer_f += Time.deltaTime;

            String min = Math.Floor(timer_f / 60).ToString("00");
            String sec = Math.Floor(timer_f % 60).ToString("00");
            String millisec = Math.Floor((timer_f * 100) % 100).ToString("00");
            GetComponent<Text>().text = String.Format("{0}:{1}:{2}", min, sec, millisec);
        }
        
    }

    void Stop()
    {
        IsRunning = false;
    }

    void Restet()
    {
        timer_f = 0f;
        IsRunning = true;
    }
}
