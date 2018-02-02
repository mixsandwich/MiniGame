using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour {
	public Text ClickCountText;
	// Use this for initialization
	void Start () {
		ClickCountText.text = GameObject.Find("SpawnPoint").GetComponent<Spawner>().ClickCount.ToString();
	}
}
