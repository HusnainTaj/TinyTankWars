﻿using UnityEngine;
using System.Collections;

public class PBullet : MonoBehaviour 
{
	public float bulletSpeed;
	private Rigidbody2D rb2D;
	public GameObject spawnPoint;

	void Awake()
	{
		spawnPoint = GameObject.FindGameObjectWithTag ("PB Spawner");
	}

	void Start()
	{
		rb2D = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag != "Player") 
		{
			Destroy (gameObject);
		}
	}

	void FixedUpdate()
	{
		transform.rotation = spawnPoint.transform.rotation;
		rb2D.AddForce (spawnPoint.transform.up * bulletSpeed);
	}
}
