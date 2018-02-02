using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("デバッグログ");
		FizzBuzzOut();
	}

	void FizzBuzzOut(){
		for(int i = 1;i<21; i++){
			if(i % 3 == 0 && i % 5 == 0){
				Debug.Log("FizzBuzz");
			}
			else if(i % 3 == 0){
				Debug.Log("Fizz");
			}
			else if(i % 5 == 0){
				Debug.Log("Buzz");
			}
			else{
				Debug.Log(i);
			}
		}
	}
}
