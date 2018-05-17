using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 r = new Vector3(15, 0, 45);
        transform.Rotate(r * Time.deltaTime);
	}
}
