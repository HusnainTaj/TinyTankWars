using UnityEngine;
using System.Collections;

public class PTwoBulletSpawn : MonoBehaviour {

	public GameObject pTwoBullet;
	public GameObject bSmoke;


	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKeyDown(KeyCode.D)) 
		{
			Instantiate (bSmoke, transform.position, Quaternion.identity);
			Instantiate (pTwoBullet, transform.position, transform.localRotation);
		}
	}
}
