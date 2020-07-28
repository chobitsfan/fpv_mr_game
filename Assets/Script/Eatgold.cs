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

    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        Ring = GameObject.Find("Ring");
  
    }

    void OnTriggerEnter(Collider collider)
    {               
        if (collider.tag == "Player")
        {
            Destroy(gameObject);
           // gameObject.SetActive(false);

            Debug.Log("gameObject :" + gameObject.name);

            Ring.SendMessage("ArrowShow");
            Ring.SendMessage("openItem");


        }
       
    }
}
