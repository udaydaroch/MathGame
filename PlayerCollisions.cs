using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    GameObject answerObject1;
    GameObject answerObject2;
    GameObject answerObject3;
    public int IntegerNum1;
    public int answer1;
    
    // Start is called before the first frame update
    void Start()
    {
         
       IntegerNum1 = MenuController.intensityForAddingAndSubtracting;  

       answerObject1 = GameObject.Find("Questions1");
       answerObject2 = GameObject.Find("Questions2");
       answerObject3 = GameObject.Find("Questions3");
    }

    void Update()
    {
    
    }

    // Update is called once per frame
     void OnTriggerEnter(Collider other)
    {

        if(other.tag == "AnswerDisplay")
        {
        
           answer1 = answerObject1.GetComponent<AddingAndSubtracting>().correctAnswer;
       
        
            if((other.gameObject.GetComponent<storedAnswers>().answerValues == answer1))
            {
                print("Correct Answer");
            }
            else 
            {
                print("Incorrect Answer");
            }

        }
        if(other.tag == "AnswerDisplay1")
        {
        
           answer1 = answerObject2.GetComponent<MultiplicationAndDivision>().correctAnswer;
       
        
            if((other.gameObject.GetComponent<storedAnswers>().answerValues1 == answer1))
            {
                print("Correct Answer");
            }
            else 
            {
                print("Incorrect Answer");
            }

        }
        if(other.tag == "AnswerDisplay2")
        {
        
           answer1 = answerObject3.GetComponent<Algebra>().correctAnswer;
       
        
            if((other.gameObject.GetComponent<storedAnswers>().answerValues2 == answer1))
            {
                print("Correct Answer");
            }
            else 
            {
                print("Incorrect Answer");
            }

        }
    }
}
