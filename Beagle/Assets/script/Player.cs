using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

//	// Use this for initialization
//	void Start () {
//	
//	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log ("Update!");
		if (Input.GetKeyDown(KeyCode.Space)) {
			Jump ();
		} else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			GoForward ();
		} else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			GoBackward ();
		}
	}

	void Jump () {
		Debug.Log ("Player Jump");
	}

	void GoForward () {
		Debug.Log ("Player GoForward");
	}

	void GoBackward () {
		Debug.Log ("Player GoBackward");
	}
}
