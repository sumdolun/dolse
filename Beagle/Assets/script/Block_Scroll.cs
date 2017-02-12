using UnityEngine;
using System.Collections;

public class Block_Scroll : MonoBehaviour {

	public GameObject Block;
	public float speed = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Block.transform.Translate (Vector3.left * speed * Time.deltaTime);

//		string TagName = Block.tag.ToString();
//
//		Debug.Log ("Object Tag Name:" + TagName);

		float BlockPosition = Block.transform.position.x;
		if (BlockPosition <= -20) {
			Vector3 temp = new Vector3(40.0f,0,0);
			Block.transform.position += temp;
		}
		Debug.Log ("BlockPosition:" + BlockPosition);	
	}
}
