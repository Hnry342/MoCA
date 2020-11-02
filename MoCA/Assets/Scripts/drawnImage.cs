using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawnImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CubeBtn()
    {
         if (PlayerPrefs.GetInt("currentQuestion").ToString()== "2")
        {
            //Remove UI before screenshot
            GameObject.Find("Cube").SetActive(false);
            GameObject.Find("CubeBtn").SetActive(false);
            GameObject.Find("CubeTxt").SetActive(false);
            //Screenshot 
            ScreenCapture.CaptureScreenshot("cube.png");
            Debug.Log("Screenshot");


             //Destroy Drawing
            if (PlayerPrefs.GetInt("currentQuestion").ToString()== "2")
            {
                Destroy (GameObject.FindWithTag("Brush"));
            }
            PlayerPrefs.SetInt("currentQuestion", 3);
        }
    }
}
