using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

	public Image splashScreen;

	IEnumerator Start(){

		splashScreen.canvasRenderer.SetAlpha (0.0f);
		fadeIn ();
		yield return new WaitForSeconds (2.5f);
		fadeOut ();
		yield return new WaitForSeconds (2.5f);
		SceneManager.LoadScene (1);
	}
	void fadeIn(){
	
		splashScreen.CrossFadeAlpha (1.0f, 1.5f, false);
	
	}
	void fadeOut(){
	
		splashScreen.CrossFadeAlpha (0.0f, 1.5f, false);
	
	}
}
