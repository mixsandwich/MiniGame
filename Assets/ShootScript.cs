using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

	public GameObject bulletPrefab;
	public float ShootSpeed;
    public GameObject Player;
    GameObject bullet;
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			//Debug.Log("Fire1");
			Shoot();
		}
	}
    void Shoot(){
		bullet = Instantiate(bulletPrefab) as GameObject;
		bullet.transform.position = this.transform.position;
        //Debug.Log(Player.rotation);
        bullet.transform.Rotate(new Vector3(0, 0, -transform.root.localEulerAngles.y));
        //bullet.transform.rotation = Player.rotation;
		Vector3 ShootForce = this.transform.forward * ShootSpeed;
		bullet.GetComponent<Rigidbody>().AddForce(ShootForce);
        Player.GetComponent<AudioSource>().Play();
	}
}