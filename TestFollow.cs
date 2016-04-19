using UnityEngine;
using System.Collections;

public class TestFollow : MonoBehaviour {
	public GameObject Player; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Player != null) {
			transform.position = new Vector2 (Player.transform.position.x, Player.transform.position.y + 1f);  
		}
	}
}
