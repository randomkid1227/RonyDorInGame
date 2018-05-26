using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogoManager : MonoBehaviour {

	public GameObject Fadeout;
	public float waitTime;
	public int nextScene;


	void Update () {

		if (Input.anyKeyDown) {
			Destroy (GameObject.Find ("LogoFadeIn"));
			Fadeout.SetActive (true);
			Debug.Log (Fadeout.GetComponent<CanvasGroup> ().alpha);

            StartCoroutine("waitSeconds");

			SceneManager.LoadScene(nextScene);
		}
			
	}

    IEnumerator waitSeconds()
    {
        yield return new WaitForSeconds(waitTime);
    }
}
