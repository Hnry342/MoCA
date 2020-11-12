using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class SpeechManager : MonoBehaviour
{
    string  fileName = "textStream.txt";

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("currentQuestion").ToString()== "4")
        {
            GameObject.Find("Rhino").SetActive(false);
            GameObject.Find("Camel").SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        var sr = File.CreateText(fileName);
        sr.WriteLine (GameObject.Find("TextStreaming").GetComponent<Text>().text);
        sr.Close();

       // if (GameObject.Find("Lion") == true)
       // {
            string result = GameObject.Find("TextStreaming").GetComponent<Text>().text;
            if (result == "lion")
            {
                Debug.Log("Success");
                GameObject.Find("Lion").SetActive(false);
                GameObject.Find("Rhino").SetActive(true);
            }
        //}
        else if (GameObject.Find("Rhino") == false)
        {

        }


    }
}
