using UnityEngine;
using System.Collections;

public class TurretRotator : MonoBehaviour {

	public float rSpeed;
	public GameObject tankBody;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	void Update()
	{
		transform.position = tankBody.transform.position;
		if (Input.GetKey(KeyCode.I)) 
		{
			transform.rotation = tankBody.transform.rotation;
		}
	}

	void FixedUpdate () 
	{
		float rHorizontal = Input.GetAxis ("T Horizontal");

		Vector3 rotation = new Vector3 (0f,0f,rHorizontal);

		transform.Rotate (rotation * rSpeed * Time.deltaTime);
	}
}
