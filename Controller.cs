using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	Rigidbody rb;
	float z;
	float x;
	Transform tr;
	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		tr = GetComponent <Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		z = Input.GetAxis ("Vertical");
		x = Input.GetAxis ("Horizontal");
		rb.MovePosition (tr.position + tr.forward * z);
		rb.AddForce (tr.forward * z *50f);
		Vector3 rotation = new Vector3 (0,x,0);
		tr.Rotate (rotation*2);
	}
	void OnCollisionEnter(Collision arg){
		if(arg.gameObject.tag == "Bounty"){
			Destroy (arg.gameObject);
		}
	}
}
