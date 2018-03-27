using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	// speedを制御する
	public float speed;
	public float rotateSpeed;
	void FixedUpdate ()
	{
		float x =  Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		//Rigidbody rigidbody = GetComponent<Rigidbody>();

		// xとyにspeedを掛ける
		//rigidbody.AddForce(x * speed, 0, z * speed);


		transform.Translate(0, 0, z * speed);
		transform.Rotate(0, x * rotateSpeed, 0);
//		if(x != 0){
//			Debug.Log("Input x:" + x);
//		}
//		if(z != 0){
//			Debug.Log("Input z:" + z);
//		}
	}
}