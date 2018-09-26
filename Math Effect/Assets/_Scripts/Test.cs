using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
<<<<<<< HEAD
        Debug.Log("ja");
=======
		print("poop");
>>>>>>> 8216b593b78488d5c002e58ab0e998338ba1d37c
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0,(Mathf.PingPong(Time.timeSinceLevelLoad,2) - 1) * 0.1f,0);
	}
}
