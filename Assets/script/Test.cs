using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
     public GameObject origin;
    // Use this for initialization
    void Start()
    {
        Instantiate(origin, new Vector3(-1.0f,11,11), Quaternion.Euler(-47.994f, 0, 0));
    }

	// Update is called once per frame
	void Update () {
		
	}
}
