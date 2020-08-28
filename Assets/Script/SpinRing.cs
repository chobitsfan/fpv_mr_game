using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinRing : MonoBehaviour
{
   public int speed = 1;

   public GameObject level2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up * speed);

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(level2, new Vector3(0,0,0), level2.transform.rotation);
        }

    }
}
