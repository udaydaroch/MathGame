using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisplayScript : MonoBehaviour
{
    public int displayControl;
    public Text levelDisplay;
    GameObject levelDisplaytext;
    // Start is called before the first frame update
    void Start()
    {
       displayControl = MenuController.Display;
       levelDisplaytext = GameObject.Find("LEVELDisplay");
       levelDisplaytext.active = true;
       displayController();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void displayController()
    {
        // A coroutine is ran which displays "Level 1" number on screen. 
        if((displayControl == 1) || (displayControl == 2) || (displayControl == 3))
        {
            StartCoroutine(LEVEL());           
        }
    }

    IEnumerator LEVEL(float waitTime = 0.7f)
    {     
              
            if((displayControl == 1) || (displayControl == 2) || (displayControl == 3))
            {
            levelDisplaytext.active = true; 
            
            yield return new WaitForSeconds(waitTime);
            
            if(displayControl == 1)
            {
            levelDisplay.text = "LEVEL 1" + "\n" + "starts in: 3";
            }else if(displayControl == 2)
            {
                levelDisplay.text = "LEVEL 2" + "\n" + "starts in: 3";
            }
            else if(displayControl == 3)
            {
                levelDisplay.text = "LEVEL 3" + "\n" + "starts in: 3";
            }
            yield return new WaitForSeconds(waitTime);
            levelDisplaytext.active = false; 
            yield return new WaitForSeconds(waitTime);
            levelDisplaytext.active = true;  
            if(displayControl == 1)
            {
            levelDisplay.text = "LEVEL 1" + "\n" + "starts in: 2";
            }else if(displayControl == 2)
            {
                levelDisplay.text = "LEVEL 2" + "\n" + "starts in: 2";
            }
            else if(displayControl == 3)
            {
                levelDisplay.text = "LEVEL 3" + "\n" + "starts in: 2";
            }
            yield return new WaitForSeconds(waitTime);
            levelDisplaytext.active = false; 
            yield return new WaitForSeconds(waitTime);
            levelDisplaytext.active = true;        
            if(displayControl == 1)
            {
            levelDisplay.text = "LEVEL 1" + "\n" + "starts in: 1";
            }else if(displayControl == 2)
            {
                levelDisplay.text = "LEVEL 2"  + "\n" + "starts in: 1";
            }
            else if(displayControl == 3)
            {
                levelDisplay.text = "LEVEL 3" + "\n" + "starts in: 1";
            }
            yield return new WaitForSeconds(waitTime);
            levelDisplaytext.active = false; 
            yield return new WaitForSeconds(waitTime);
            levelDisplaytext.active = true;
            if((displayControl == 1) || (displayControl == 2) || (displayControl == 3))
            {
            levelDisplay.text = "Go!!";
            }
            yield return new WaitForSeconds(waitTime);
            levelDisplaytext.active = false; 

            

                  
            }
    }
}
