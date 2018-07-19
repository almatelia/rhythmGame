using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWatch : MonoBehaviour {
    System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
    float elapsed    = 0;
    float musicTime  = 0;
    // Use this for initialization
    void Start () {

        stopwatch.Start();
    }
	
	// Update is called once per frame
	void Update () {
      //  musicTime = Time.time;
        elapsed =(float)stopwatch.Elapsed.TotalSeconds;
        if (elapsed >= 10.0)
        {
            Debug.Log("10秒経過");
        }
       // Debug.Log("新"+elapsed);
    }
}
