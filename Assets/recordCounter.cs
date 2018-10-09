using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class recordCounter : Score
{

    public Text Max;
    public int max = 0;
    public string fileName = "record.txt";
    // Use this for initialization

    public void UpdateTexts(int score)
    {
        Max.text = ("Record : " + max.ToString());
    }

    // Update is called once per frame
    void Update()
    {

        if ((int)points > max)
            max = (int)points;
        UpdateTexts(max);

    }

    /*
    void Start()
    {
        if (File.Exists(fileName))
        {
            Debug.Log(fileName + " already exists.");
            return;
        }
    }

    public void ReadFile(file : String){


       var sr = File.CreateText(fileName);
            if(File.Exists(file)){
            var FF = File.OpenText(file);
       var line = FF.ReadLine();
            if((int)line > (int) points ){
                FF.WriteLine(max);
                UpdateTexts(max);
                FF.Close();
                }
        } else {
            Debug.Log("Could not Open the file: " + file + " for reading.");
            return;
        }
    }*/
}