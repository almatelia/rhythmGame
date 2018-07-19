using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KEY : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Key入力");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S");
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D");
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F");
        }
    }
}
