using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Response : MonoBehaviour
{
    public AudioSource a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z;
    float timer;
    float seconds;
    bool stopTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        a.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if (stopTimer == false)
        {
                timerStart();
        }

        if (Input.GetMouseButtonDown(0))
        {
            stopTimer = true;
            Debug.Log("You took " + seconds.ToString("#.00") + " to click");
        }
     

    }

    void timerStart(){
        timer += Time.deltaTime;
        seconds = timer % 60;
        Debug.Log(seconds.ToString("#.00"));
    }
}
