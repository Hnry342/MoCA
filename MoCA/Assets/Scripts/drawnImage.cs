using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawnImage : MonoBehaviour
{

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

            StartCoroutine(clearCoroutine());
        
        }
    }

    public void ClockBtn()
    {
         if (PlayerPrefs.GetInt("currentQuestion").ToString()== "3")
        {
            //Remove UI before screenshot
            GameObject.Find("ClockBtn").SetActive(false);
            GameObject.Find("ClockTxt").SetActive(false);
            //Screenshot 
            ScreenCapture.CaptureScreenshot("clock.png");
            Debug.Log("Screenshot");

            StartCoroutine(clearCoroutine());
        
        }
    }

        IEnumerator clearCoroutine()
    {
            //Destroy Drawing wait 1 second to allow for screenshot
            yield return new WaitForSeconds(1);
            //Destroy drawing
            GameObject[] brushes = GameObject.FindGameObjectsWithTag("Brush");
            foreach(GameObject brush in brushes)
            {
                GameObject.Destroy(brush);   
            }         
            //Change current question to enable/disable canvas or switch scene
            if (PlayerPrefs.GetInt("currentQuestion").ToString()== "2")
            {
            PlayerPrefs.SetInt("currentQuestion", 3);
            }
            else if (PlayerPrefs.GetInt("currentQuestion").ToString()== "3")
            {

            }

    }
}
