using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.IO;


public class GameManager : MonoBehaviour {

    public GameObject[] notes;
    private float[] _timing;
    private int[] _linenum;

    public string filePass;

    private bool _isPlaying = false;

    //音楽File
    private AudioSource _audioSource;

    //音楽再生時間
    private float _startTime = 0;
    private float _musicTime = 0;
    private int    count_num = 0;
    private int sc = 0;

    //
    System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

    public Text tx_music;
    public Text humen_time;
    public Text Button_num;
    public Text score;

    //譜面関係
    private int count_humen = 0;
    
    

    //Notes
    public GameObject N1;
    public GameObject N2;
    public GameObject N3;
    public GameObject N4;

    void Start() {
        
        _audioSource = GameObject.Find("GameMusic").GetComponent<AudioSource>();
        _timing = new float[1024];
        _linenum = new int[1024];
        LoadCSV();
        
        _audioSource.Play();
       // _startTime = Time.time;
        stopwatch.Start();

        //   Debug.Log(_startTime);
    }



    void LoadCSV()
    {
        int i = 0, j;
        TextAsset csv = Resources.Load(filePass) as TextAsset;
        StringReader reader = new StringReader(csv.text);
        while (reader.Peek() > -1)
        {

            string line = reader.ReadLine();
            string[] values = line.Split(',');
            for (j = 0; j < values.Length; j++)
            {
                _timing[i] = float.Parse(values[0]);
                _linenum[i] = int.Parse(values[1]);
             //Debug.Log("タイミング"+_timing[i] +"ボタン" + _linenum[i]);
            }
            i++;
        }
    } 
	
	// Update is called once per frame
	void Update () {
         
        _musicTime = (float)stopwatch.Elapsed.TotalSeconds;
        tx_music.text = (_musicTime).ToString();
        //  float v = _timing[count_humen] - 1.4f;
        float v = _timing[count_humen] - 1.2f;
        if (_musicTime >= v)
        //if (_musicTime<= _timing[count_humen]+10)
        {
            
            humen_time.text = (_timing[count_humen]).ToString();

            Button_num.text = (_linenum[count_num]).ToString();

            switch (_linenum[count_num])
            {
                case 1:
                    Instantiate(N1, new Vector3(-14.66f, 5.32f,40.4f), Quaternion.identity);
                
                    break;
                case 2:
                    Instantiate(N2, new Vector3(-4.93f, 5.32f, 42.4f), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(N3, new Vector3(4.4f, 5.32f, 42.4f), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(N4, new Vector3(13.84f, 5.32f, 42.4f), Quaternion.identity);
                    break;
                default:
                    break;
            }

            count_humen++;
            count_num++;


        }

 
    }

    

   public void Addsc()
    {
        //  Debug.Log("呼び出し"+ _musicTime);
        sc++;
        score.text = (sc).ToString();
        


    }
}
