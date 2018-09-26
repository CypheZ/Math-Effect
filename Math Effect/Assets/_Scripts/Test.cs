using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("poop");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0,(Mathf.PingPong(Time.timeSinceLevelLoad,2) - 1) * 0.1f,0);
	}
}
