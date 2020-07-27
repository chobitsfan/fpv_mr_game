using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class RingEvent : MonoBehaviour
{
    public GameObject[] respawns;
    public GameObject[] arrowList;

    public GameObject timer_ui;

    Eatgold RingItem;
    int temp = 0;
    int t = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        timer_ui = GameObject.Find("UI_timer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void stopTime()
    {
        timer_ui.SendMessage("Stop");       
       
    }

    void ArrowShow()
    {
        if (temp < arrowList.Length)
        {
            arrowList[temp].SetActive(false);
            temp++;
            arrowList[temp].SetActive(true);
            Debug.Log("temp :" + temp);
        }
       
    }

    void openItem()
    {
        if (t < respawns.Length)
        {
            respawns[t].SetActive(true);
            t++;
        }
    }

}
