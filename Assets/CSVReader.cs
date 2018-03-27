using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSVReader : MonoBehaviour
{
    public TextAsset CSVfile;
    public List<string[]> csvDatas = new List<string[]>();
    public Text Quiz;
    public Text Select1, Select2, Select3, Select4;
    string Answer;
    //public Canvasgroup canvasgroup;

    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    QuizLoad();
        //}
    }

    // Update is called once per frame
    public void QuizLoad()
    {
        string[] lines = CSVfile.text.Replace("\r\n", "\n").Split("\n"[0]);
        foreach (string line in lines)
        {
            if (line == "") { continue; }
            csvDatas.Add(line.Split(','));

        }
        int RandomNum = Random.Range(0, 32);
        Quiz.text = csvDatas[RandomNum][0];
        Answer = csvDatas[RandomNum][1];
        Select1.text = csvDatas[RandomNum][2];
        Select2.text = csvDatas[RandomNum][3];
        Select3.text = csvDatas[RandomNum][4];
        Select4.text = csvDatas[RandomNum][5];
    }
}