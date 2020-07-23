using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Eatgold : MonoBehaviour
{
    int Score = 0;
    int temp;

    public string[] RingArray;

    public GameObject Ring;

    // Start is called before the first frame update
    void Start()
    {
        Ring = GameObject.Find("Ring");      
    }

    void OnCollisionEnter(Collision collision)
    {               
        if (collision.gameObject.tag == "Player")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);

            if (gameObject.name == "Ring_1")
            {
                Ring.SendMessage("openItem4");
            }
            else if (gameObject.name == "Ring_2")
            {
                Ring.SendMessage("openItem5");
            }
            else if (gameObject.name == "Ring_5")
            {
                Ring.SendMessage("stopTime");
            }
            

        }
       
    }

   
}
