using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public GameManager GM;
    public GameObject PER_part;
    public GameObject GRE_part;
    public GameObject GOO_part;

    private float _musicTime = 0;
    System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
    private float z = 0;
    bool isColled = false;
    // Use this for initialization
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        stopwatch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        _musicTime = (float)stopwatch.Elapsed.TotalSeconds;
        //  this.gameObject.transform.Translate(0, 0,-1f);
        this.gameObject.transform.Translate(0, 0, -1f);
        z = this.transform.position.z;
        if (this.transform.position.z < -35.89f)
        {

          //  Debug.Log(Time.time);
            Destroy(this.gameObject);
        }

    }


    private void OnTriggerStay(Collider other)
    {

        if ((Input.GetKeyDown(KeyCode.D) ))
        {

         if ((z >= -22.0) && (z <= -18.0))
           {
                if (isColled == false)
                {
                    Instantiate(GOO_part, new Vector3(this.transform.position.x, this.transform.position.y + 2.0f, this.transform.position.z), Quaternion.Euler(90, 0, 0));
                    Destroy(this.gameObject);
                    GM.Addsc();
                    isColled = true;
                }
           }


         else if ((z >= -25.0) && (z <= -22.0))
            {
                if (isColled == false)
                {
                    Instantiate(GRE_part, new Vector3(this.transform.position.x, this.transform.position.y + 2.0f, this.transform.position.z), Quaternion.Euler(90, 0, 0));
                    Destroy(this.gameObject);
                    GM.Addsc();
                    isColled = true;
                }
            }

        else if ((z >= -32.0) && (z <= -25.0))
            {

                if (isColled == false)
                {
                    Instantiate(PER_part, new Vector3(this.transform.position.x, this.transform.position.y + 2.0f, this.transform.position.z), Quaternion.Euler(90, 0, 0));
                    Destroy(this.gameObject);
                    GM.Addsc();
                    isColled = true;
                }


            }
            else if ((z >= - 35.21) && (z <= -32.0))
            {

                if (isColled == false)
                {
                    Instantiate(PER_part, new Vector3(this.transform.position.x, this.transform.position.y + 2.0f, this.transform.position.z), Quaternion.Euler(90, 0, 0));
                    Destroy(this.gameObject);
                    GM.Addsc();
                    isColled = true;
                }


            }
        }

    }
}
