using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class RingEvent : MonoBehaviour
{
    public GameObject[] respawns;

    public GameObject timer_ui;
    
    // Start is called before the first frame update
    void Start()
    {
        timer_ui = GameObject.Find("UI_timer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void openItem4()
    {
        respawns[0].SetActive(true);
    }

    void openItem5()
    {
        respawns[1].SetActive(true);
    }

    void stopTime()
    {
        timer_ui.SendMessage("Stop");       
       
    }


}
