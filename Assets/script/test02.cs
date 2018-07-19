using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test02 : MonoBehaviour {
    private float test = 0;
	// Use this for initialization
	void Start () {
        Debug.Log(test);
        
    }
	
	// Update is called once per frame
	void Update () {
        test += 0.1f;
        if(test >=3.0f+4.0f)
        {
            Debug.Log("S"+test);
        }

        //Debug.Log(test);
    }
}
