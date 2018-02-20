using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class Quiztext: MonoBehaviour{
	public Text quiz;
	private string str;

	void Start(){

	}
	void Update()
	{
		if (Input.GetMouseButtonDown(0)) {
			//CSVファイルを読み出し
			TextAsset csv = Resources.Load("text/quizdata") as TextAsset;
			StringReader reader = new StringReader(csv.text);
			while(reader.Peek() > -1)
			{
				str = reader.ReadLine();
				string[] question = str.Split(',');
				quiz.text = question[2];
			}     
		}      
	}
}