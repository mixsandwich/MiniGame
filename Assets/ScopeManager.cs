using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeManager : MonoBehaviour {

    public GameObject ObjOther1;
    public GameObject ObjOther2;
    public GameObject ObjOther3;
    public GameObject ObjScope;
    public bool scope;

	// Use this for initialization
	void Start () {
        scope = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1))
        {
            if(scope){
                OnScope();
            }
            else{
                OffScope();
            }
            scope = !scope;
        }
	}

    public void OnScope()
    {
        ObjOther1.SetActive(false);
        ObjOther2.SetActive(false);
        ObjOther3.SetActive(false);
        ObjScope.SetActive(true);
        Debug.Log("OnScope");
    }

    public void OffScope()
    {
        ObjOther1.SetActive(true);
        ObjOther2.SetActive(true);
        ObjOther3.SetActive(true);
        ObjScope.SetActive(false);
        Debug.Log("OffScope");

    }
}