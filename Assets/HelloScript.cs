using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloScript : MonoBehaviour
{
    int num;

    string Add(int a, string b)
    {
        string c = "";
        for (int i = 0; i > a; i++){
            c += b;
        }
        return c;
    }

    void Start()
    {
        string answer;
        answer = Add(2, "おはよう");
        Debug.Log(answer);
    }
}