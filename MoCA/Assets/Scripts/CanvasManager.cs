using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
   // public static CanvasManager instance;

    public GameObject CanvasQ1;
    public GameObject CanvasQ2;
    public GameObject CanvasQ3;
    // Start is called before the first frame update
 /*    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    } */

    void Start()
    {
        PlayerPrefs.SetInt("currentQuestion", 1);

    }

    // Update is called once per frame
    void Update()
    {
       
        if ( PlayerPrefs.GetInt("currentQuestion") == 1)
        {
            Question1();
        }
        if ( PlayerPrefs.GetInt("currentQuestion") == 2)
        {
            //Debug.Log("QUESTION 2");
            Question2();
        }

    }

    public void Question1()
        {
            
            CanvasQ1.SetActive(true);
            CanvasQ2.SetActive(false);
            CanvasQ3.SetActive(false);


        }
    public void Question2()
        {
            CanvasQ1.SetActive(false);
            CanvasQ2.SetActive(true);
            CanvasQ3.SetActive(false);
        }
    public void Question3()
        {
            CanvasQ1.SetActive(false);
            CanvasQ2.SetActive(false);
            CanvasQ3.SetActive(true);
        }
}
