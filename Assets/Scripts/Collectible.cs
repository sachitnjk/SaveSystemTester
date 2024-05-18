using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.CompareTag("Player"))
		{
			CoinPickHandler coinPickHandler = collision.gameObject.GetComponent<CoinPickHandler>();
			if(coinPickHandler != null ) 
			{
				coinPickHandler.Collect();
			}
		}

		Destroy(this.gameObject);
	}
}
