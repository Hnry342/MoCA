using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Main : MonoBehaviour
{
    public TMP_Text welcome;
    // Start is called before the first frame update
    void Start()
    {
        welcome.text = PlayerPrefs.GetString("username") + ", Click start to begin test";
        Debug.Log( PlayerPrefs.GetString("username"));
    }

    
}
