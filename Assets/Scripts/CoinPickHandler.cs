using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickHandler : MonoBehaviour
{
	public int coinsCollected { get; private set; }

	private void Start()
	{
		coinsCollected = 0;
	}

	public void Collect()
	{
		coinsCollected++;
	}


}
