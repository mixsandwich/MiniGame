using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {
    public int RemainingTime;
	// Use this for initialization
	void Start () {
        StartCoroutine("TimeBomb");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator TimeBomb(){
        yield return new WaitForSeconds(RemainingTime);
        Destroy(this.gameObject);
        yield return null;
    }
}
