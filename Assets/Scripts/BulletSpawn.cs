using UnityEngine;
using System.Collections;

public class BulletSpawn : MonoBehaviour {

	public GameObject pBullet;
	public GameObject bSmoke;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKeyDown(KeyCode.Semicolon)) 
		{
			Instantiate (bSmoke, transform.position, Quaternion.identity);
			Instantiate (pBullet, transform.position, transform.localRotation);
		}
	}
}
