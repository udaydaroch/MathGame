using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    static public int intensityForAddingAndSubtracting = 10;
    static public int intensityForDivisionAndMultiplication = 10;
    static public int intensityForAlgebra = 10;
    static public int Display = 1;
    static public int platformDecider =1;
    
    // Start is called before the first frame update
     public void InputDataForEasyDropDown(int val1)
    {
        if(val1 == 1)
        {
         SceneManager.LoadScene("Level1");
         MenuController.intensityForAddingAndSubtracting = 10;
         MenuController.Display = 1; 
         MenuController.platformDecider = 1;
        }
        if(val1 == 2)
        { 
         SceneManager.LoadScene("Level2");
         MenuController.intensityForDivisionAndMultiplication = 4;
         MenuController.Display = 2;
         MenuController.platformDecider = 2;
         
        }
    }

    public void InputDataForMediumDropDown(int val2)
    {
        if(val2 == 1)
        {
         SceneManager.LoadScene("Level1");
         MenuController.intensityForAddingAndSubtracting = 15;
         MenuController.Display = 1; 
         MenuController.platformDecider = 1;
        }
        if(val2 == 2)
        {
         SceneManager.LoadScene("Level2");
         MenuController.intensityForDivisionAndMultiplication = 8;
         MenuController.Display = 2;
         MenuController.platformDecider = 2;
        }
        if(val2 == 3)
        {
         SceneManager.LoadScene("Level3");
        MenuController.intensityForAlgebra = 5;
        MenuController.Display = 3;
        MenuController.platformDecider = 3;
        }
    }




    public void InputDataForHardDropDown(int val3)
    {
        if(val3 == 1)
        {
         SceneManager.LoadScene("Level1");
         MenuController.intensityForAddingAndSubtracting = 25;
         MenuController.Display = 1; 
         MenuController.platformDecider = 1;
        
        }
        if(val3 == 2)
        {
         SceneManager.LoadScene("Level2");
         MenuController.intensityForDivisionAndMultiplication = 12;
         MenuController.Display = 2;
         MenuController.platformDecider = 2;
        }
        if(val3 == 3)
        {
         SceneManager.LoadScene("Level3");
         MenuController.intensityForAlgebra = 10;
         MenuController.Display = 3;
         MenuController.platformDecider = 3;
        }
    }
}
