using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerTwoMovement : MonoBehaviour {

	public float mSpeed;
	public float rSpeed;
	public float pTwoMaxHP = 100;
	public float pTwoCurrentHP;
	public Image pTwohealthBar;
	public GameObject pTwoTankBody;
	public GameObject pTwoTurret;

	void Start () 
	{
		pTwoCurrentHP = pTwoMaxHP;
	}

	void Update()
	{
		pTwohealthBar.fillAmount = pTwoCurrentHP / pTwoMaxHP;
		if (pTwoCurrentHP <= 0) 
		{
			pTwoTankBody.gameObject.SetActive (false);
			pTwoTurret.gameObject.SetActive (false);
			SceneManager.LoadScene (5);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.transform.tag == "P Bullets") 
		{
			Destroy (other.gameObject);
			pTwoCurrentHP -= 10;
		}
	}

	void FixedUpdate () 
	{
		float mVertical = Input.GetAxis ("P2 Vertical");
		float rHorizontal = Input.GetAxis ("P2 Horizontal");

		Vector3 rotation = new Vector3 (0f,0f,rHorizontal);
		Vector2 movement = new Vector2 (0f, mVertical);

		transform.Translate (movement * mSpeed * Time.deltaTime);

		if (Input.GetKey(KeyCode.G)) 
		{
			transform.Rotate (-rotation * rSpeed * Time.deltaTime);
		} else 
		{
			transform.Rotate (rotation * rSpeed * Time.deltaTime);	
		}
	}
}
