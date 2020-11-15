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
        //if (PlayerPrefs.GetInt("currentQuestion").ToString()== "4")
        //{
            GameObject.Find("Rhino").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Camel").GetComponent<SpriteRenderer>().enabled = false;
       // }
    }

    // Update is called once per frame
    void Update()
    {
///////////Question 4/////////////////////
        if (PlayerPrefs.GetInt("currentQuestion").ToString()== "4")
        {
            if (GameObject.Find("Lion").GetComponent<SpriteRenderer>().enabled == true)
            {
                if (GameObject.Find("TextStreaming").GetComponent<Text>().text.Trim() == "lion")
                {
                    GameObject.Find("Lion").GetComponent<SpriteRenderer>().enabled = false;
                    GameObject.FindWithTag("Rhino").GetComponent<SpriteRenderer>().enabled = true;
                }
            }
            else if (GameObject.Find("Rhino").GetComponent<SpriteRenderer>().enabled == true)
            {
                if (GameObject.Find("TextStreaming").GetComponent<Text>().text.Trim() == "Rhino")
                {
                    GameObject.Find("Rhino").GetComponent<SpriteRenderer>().enabled = false;
                    GameObject.FindWithTag("Camel").GetComponent<SpriteRenderer>().enabled = true;
                }

            }
            else if (GameObject.Find("Camel").GetComponent<SpriteRenderer>().enabled == true)
            {
                if (GameObject.Find("TextStreaming").GetComponent<Text>().text.Trim() == "Camel")
                {
                    GameObject.Find("Camel").GetComponent<SpriteRenderer>().enabled = false;
                    PlayerPrefs.SetInt("currentQuestion", 5);
                }

            }
        }
////////////////////////////////////////Question 4 end//////////////////
    }
}
