using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObject : MonoBehaviour
{
    bool mouseHeld = false;
    string[ ] correctSequence = new string[] {"1", "A", "2", "B", "3", "C", "4","D","5","E"} ;
    public int correct = 0; 
    public int Qcount = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Check for mouse up and down
        if (Input.GetMouseButtonDown(0))
        {
            mouseHeld = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            mouseHeld = false;
        }

        //Collision
          //Declare collision raycast
        Vector2 circleRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D circleHit = Physics2D.Raycast(circleRay, Vector2.zero);
        //if conditions for collisions
        if (circleHit && circleHit.collider.enabled && mouseHeld)
        {
            //If collider Name == Correct Sequence
            if (circleHit.collider.name == correctSequence[Qcount])
            {
                Debug.Log("Correct! " + circleHit.collider.name + " correct answer is " + correctSequence[Qcount]);
                //+1 on correct score
                correct++;
                //Disable collider after touch
                circleHit.collider.enabled = !circleHit.collider.enabled;
            }
            else if (circleHit.collider.name != correctSequence[Qcount])
            {
                Debug.Log("Wrong! " + circleHit.collider.name + " correct answer is " + correctSequence[Qcount]);
                //Disable collider after touch
                circleHit.collider.enabled = !circleHit.collider.enabled;
            }
            //Increase Count
            Qcount++;
        }
        //Check if Qcount = 10
        if (Qcount >= 10)
        {
            //check if score is 10 (pass) or less (fail)
           if (correct >= 10)
           {
            Debug.Log("Pass ");
            PlayerPrefs.SetInt("Q1", 1);

           }
           else if (correct < 10)
           {
            Debug.Log("Fail ");
            PlayerPrefs.SetInt("Q1", 0); 
           }
           //Reset count
            //Qcount = 0;
            //correct = 0; 
            //Debug.Log( PlayerPrefs.GetInt("Q1").ToString());
            if (PlayerPrefs.GetInt("currentQuestion").ToString()== "1")
            {
                GameObject[] brushes = GameObject.FindGameObjectsWithTag("Brush");
                foreach(GameObject brush in brushes)
                {
                    GameObject.Destroy(brush);   
                }         
            
            }
            PlayerPrefs.SetInt("currentQuestion", 2);
            Qcount = 0;


        }
    }

      void OnMouseOver()
    {
      
    }
}
