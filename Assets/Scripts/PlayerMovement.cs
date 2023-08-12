using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float mSpeed;
	public float rSpeed;
	public float maxHP = 100;
	public float currentHP;
	public Image healthBar;
	public GameObject tankBody;
	public GameObject turret;

	void Start () 
	{
		currentHP = maxHP;
	}

	void Update()
	{
		healthBar.fillAmount = currentHP / maxHP;
		if (currentHP <= 0) 
		{
			tankBody.gameObject.SetActive (false);
			turret.gameObject.SetActive (false);
			SceneManager.LoadScene (4);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.transform.tag == "PTwo Bullet") 
		{
			Destroy (other.gameObject);
			currentHP -= 10;
		}
	}

	void FixedUpdate () 
	{
		float mVertical = Input.GetAxis ("Vertical");
		float rHorizontal = Input.GetAxis ("Horizontal");

		Vector3 rotation = new Vector3 (0f,0f,rHorizontal);
		Vector2 movement = new Vector2 (0f, mVertical);

		transform.Translate (movement * mSpeed * Time.deltaTime);
	
		if (Input.GetKey(KeyCode.DownArrow)) 
		{
			transform.Rotate (-rotation * rSpeed * Time.deltaTime);
		} else 
		{
			transform.Rotate (rotation * rSpeed * Time.deltaTime);	
		}
	}
}
