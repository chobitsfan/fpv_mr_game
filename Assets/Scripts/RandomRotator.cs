using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField]
    private float tumble;
    public GameObject explosion;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble; /*隨機半徑*/
       // GetComponent<Rigidbody>().transform.Rotate(Vector3.up * tumble);
    }

    void OnCollisionEnter(Collision other)
    {        
        if (other.gameObject.tag == "Player")
         {
            //  Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            Debug.Log("gameObject :" + gameObject.name);

         }
        if (other.gameObject.tag == "floor")
        {
            //  Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Debug.Log("gameObject :" + gameObject.name);

        }

    }
}