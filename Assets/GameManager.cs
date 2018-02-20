using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public string musicName; // 曲名
	private CSVReader musicData; // 譜面データ

	void Start() {
		musicData = GameObject.Find("ReaderObject").GetComponent<CSVReader>();
		musicData.CsvRead(musicName);
		for (int i = 0; i < musicData.csvDatas.Count; i++) {
			for (int j = 0; j < musicData.csvDatas[i].Length; j++) {
				Debug.Log("csvDatas[" + i + "][" + j + "] = " + musicData.csvDatas[i][j]);
			}
		}
	}
}