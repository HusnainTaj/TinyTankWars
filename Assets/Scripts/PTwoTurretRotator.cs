using UnityEngine;
using System.Collections;

public class PTwoTurretRotator : MonoBehaviour {
	
	public float rSpeed;
	public GameObject pTwoTankBody;

	// Use this for initialization
	void Start () 
	{

	}

	void Update()
	{
		transform.position = pTwoTankBody.transform.position;
		if (Input.GetKey(KeyCode.Q)) 
		{
			transform.rotation = pTwoTankBody.transform.rotation;
		}
	}

	void FixedUpdate () 
	{
		float rHorizontal = Input.GetAxis ("P2 T Horizontal");

		Vector3 rotation = new Vector3 (0f,0f,rHorizontal);

		transform.Rotate (rotation * rSpeed * Time.deltaTime);
	}
}
