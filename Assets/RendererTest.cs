using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendererTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			ChangeColor();
		}
	}
	void ChangeColor(){
		GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 0.0f, 0.5f);
	}
}
