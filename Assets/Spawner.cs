using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	
	public GameObject cube;
	public Transform SpownPoint;
	public int ClickCount;
	// Use this for initialization
	//ゲーム起動時に最初に実行される
	void Start () {
		//SpawnCube()関数が実行される
		SpawnCube();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			//クリックカウントを増やす
			ClickCount++;
//			SpawnCube();
		}
	}
	public void SpawnCube(){
		//newCubeという名前のGameObjectを宣言し、cubeという名前のprefabをSpownPointに生成（インスタンス化）している
		GameObject newCube = (GameObject)Instantiate (cube, SpownPoint);
		//もし、ClickCountが0だった場合
		if(ClickCount == 0){
			//newCubeのtransformのlocalScaleを2.5倍にしている
			newCube.transform.localScale *= 2.5f;
		}
		else if(ClickCount % 15 == 0){
			//Scaleを掛け算する
			newCube.transform.localScale *= 4;
			//newCubeのRendererコンポーネントを取得し、materialのcolorを黄色にする
			newCube.GetComponent<Renderer>().material.color = Color.yellow;
		}
		else if(ClickCount % 5 == 0){
			//Scaleを掛け算する
			newCube.transform.localScale *= 3.5f;
			newCube.GetComponent<Renderer>().material.color = Color.green;
		}
		else if(ClickCount % 3 == 0){
			//Scaleを掛け算する
			newCube.transform.localScale *= 3;
			newCube.GetComponent<Renderer>().material.color = Color.red;
		}
		else{
			//Scaleを掛け算する
			newCube.transform.localScale *= 2.5f;
		}
	}
}
