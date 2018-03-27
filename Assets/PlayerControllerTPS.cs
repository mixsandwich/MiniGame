using UnityEngine;
using System.Collections;

public class PlayerControllerTPS : MonoBehaviour {
	//Cantrackという名前の、booleanを宣言している。publicにしている。
	public bool CanTrack;
	public bool collided;
	private Vector3 position;
	private Vector3 WorldPointPos;

	void Update (){
		if(CanTrack){
			Track();
		}
		//マウスの左クリックの判定
		if(Input.GetMouseButtonDown(0)){
			CanTrack = false;
			GetComponent<Rigidbody>().useGravity = true;
		}
		if(GetComponent<Rigidbody>().IsSleeping() && CanTrack == false){
			GetComponent<MeshRenderer>().material.color *= new Color(0.2f, 0.2f, 0.2f, 0.5f);
		}

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		if(Input.GetButtonDown("Fire1")){
			Debug.Log("Fire1");
		}
	}
	void Track(){
		//マウス位置座標をVector3で取得
		position = Input.mousePosition;
		//z座標を固定（カメラからの位置を取得）
		position.z = -Camera.main.transform.position.z;
//		position.z = 10.0f;
		//スクリーン座標をワールド座標に変換している
		WorldPointPos = Camera.main.ScreenToWorldPoint(position);

		// 壁を突き抜けないようにx軸の移動範囲を限定
		float MoveRangeX = GameObject.Find("Base").transform.localScale.x/2;

		if (WorldPointPos.x <= -MoveRangeX) {
			WorldPointPos.x = -MoveRangeX;
		} else if (WorldPointPos.x >= MoveRangeX) {
			WorldPointPos.x = MoveRangeX;
		}

		//y軸は固定
		WorldPointPos.y = GameObject.Find("SpawnPoint").transform.position.y;
//		WorldPointPos.y = 10f;
		//ワールド座標をPlayer位置へ変換
		gameObject.transform.position = WorldPointPos;
	}
	//衝突した時に実行される関数
	void OnCollisionEnter(){
		if(collided == false && CanTrack == false){

			//SpawnPointというゲームオブジェクトを探して、Spawnerというスクリプトの
			//SpawnCube()という関数を実行している

			GameObject.Find("SpawnPoint").GetComponent<Spawner>().SpawnCube();
			//collidedにtrueを代入
			collided = true;
		}
	}
}