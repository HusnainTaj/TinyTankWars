using UnityEngine;
using System.Collections;

public class SmokeCleaner : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, 0.5f);
	}
}
