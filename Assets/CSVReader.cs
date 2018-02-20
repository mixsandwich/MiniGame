using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVReader : MonoBehaviour {

	public List<string[]> csvDatas;

	public void CsvRead (string musicName) {
		csvDatas = new List<string[]>();
		// csvをロード
		TextAsset csv = Resources.Load ("text/" + musicName) as TextAsset;
		StringReader reader = new StringReader (csv.text);
		while (reader.Peek () > -1) {
			// ','ごとに区切って配列へ格納
			string line = reader.ReadLine ();
			csvDatas.Add (line.Split (','));
		}
	}
}