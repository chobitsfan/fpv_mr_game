using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	

	void OnTriggerEnter(Collider other)
	{
		
		if (explosion != null) {
			Instantiate(explosion, transform.position, transform.rotation);
		}

		if (other.CompareTag("Player")) {
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);

		} 

		Destroy(other.gameObject); // Bolt or Player
		Destroy(gameObject); // Asteroid
	}
}
