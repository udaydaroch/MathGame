using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddingAndSubtracting : MonoBehaviour
{
    public int IntegerNum;
    public int questionAnswer1;
    public int questionAnswer2;
    public int questionAnswer3;
    public int correctAnswer;
    public string qText;
    public Text questionText;
    private int questionNum;
    public GameObject answerTextBox;
    public static List<GameObject> questionParts = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {

        IntegerNum = MenuController.intensityForAddingAndSubtracting;
        
        Debug.Log(IntegerNum);
        AdditionAndSubstraction();
        
       
    }

    // Update is called once per frame
    public void AdditionAndSubstraction()
    {
        foreach(GameObject previousQuestions in questionParts)
        {
            Destroy(previousQuestions);
        }

        questionParts = new List<GameObject>();

        int number1 = Mathf.FloorToInt(Random.value * IntegerNum);
        while (number1 == 0)
        {
            number1 = Mathf.FloorToInt(Random.value * IntegerNum);
        }
        int number2 = Mathf.FloorToInt(Random.value * IntegerNum);
        while (number2 == 0 || number2 == number1)
        {
            number2 = Mathf.FloorToInt(Random.value * IntegerNum);
        }
        int number6 = Mathf.FloorToInt(Random.value * IntegerNum);
        while (number6 == 0 || number6 == number2 || number6 == number1)
        {
            number6 = Mathf.FloorToInt(Random.value * IntegerNum);
        }


        // number4 and 5 are two random numbers that are subtracted off the correctanswer to create two different wrongAnswers.
        int number4 = Random.Range(-5, 5);
        while (number4 == 0)
        {
            number4 = Random.Range(-5, 5);
            
        }
        Debug.Log(number4);

        int number3 = Random.Range(-5, 5);
        while (number3 == number4 || number3 == 0)
        {
            number3 = Random.Range(-5, 5);
        }
        Debug.Log(number3);


        int questions = Mathf.FloorToInt(Random.value * 2);
        int shuffleAnswers = Mathf.FloorToInt(Random.Range(0, 3));


        if ((IntegerNum == 10) || (IntegerNum == 15) || (IntegerNum == 25))

        {
            switch (questions)
            {

                case 0:

                    if (shuffleAnswers == 0)
                    {
                        if (IntegerNum == 10)
                        {
                            correctAnswer = questionAnswer1 = number1 + number2;
                            questionAnswer2 = number1 + number2 - number3;
                            questionAnswer3 = number1 + number2 - number4;
                            qText = number1 + " + " + number2 + " = ?";
                            Debug.Log(qText);
                            questionText.text = qText;
                        }
                        else if ((IntegerNum == 15) || (IntegerNum == 25))
                        {
                            correctAnswer = questionAnswer1 = number1 + number2 - number6;
                            questionAnswer2 = number1 + number2 - number6 - number3;
                            questionAnswer3 = number1 + number2 - number6 - number4;
                            qText = number1 + " + " + number2 + " - " + number6 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }

                    }
                    else if (shuffleAnswers == 1)
                    {
                        if (IntegerNum == 10)
                        {
                            questionAnswer3 = number1 + number2 - number3;
                            correctAnswer = questionAnswer1 = number1 + number2;
                            questionAnswer2 = number1 + number2 - number4;
                            qText = number1 + " + " + number2 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if ((IntegerNum == 15) || (IntegerNum == 25))
                        {
                            questionAnswer3 = number1 + number2 - number6 - number4;
                            correctAnswer = questionAnswer1 = number1 + number2 - number6;
                            questionAnswer2 = number1 + number2 - number6 - number3;
                            qText = number1 + " + " + number2 + " - " + number6 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }



                    }
                    else if (shuffleAnswers == 2)
                    {
                        if (IntegerNum == 0)
                        {
                            questionAnswer2 = number1 + number2 - number4;
                            questionAnswer3 = number1 + number2 - number3;
                            correctAnswer = questionAnswer1 = number1 + number2;
                            qText = number1 + " + " + number2 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if ((IntegerNum == 15) || (IntegerNum == 25))
                        {
                            questionAnswer2 = number1 + number2 - number6 - number3;
                            questionAnswer3 = number1 + number2 - number6 - number4;
                            correctAnswer = questionAnswer1 = number1 + number2 - number6;
                            qText = number1 + " + " + number2 + " - " + number6 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                    }

                    break;

                case 1:


                    if (shuffleAnswers == 0)
                    {
                        if (IntegerNum == 10)
                        {
                            correctAnswer = questionAnswer1 = number1 - number2;
                            questionAnswer2 = number1 - number2 - number3;
                            questionAnswer3 = number1 - number2 - number4;
                            qText = number1 + " - " + number2 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if ((IntegerNum == 15) || (IntegerNum == 25))
                        {
                            correctAnswer = questionAnswer1 = number1 - number2 + number6;
                            questionAnswer2 = number1 - number2 + number6 - number3;
                            questionAnswer3 = number1 - number2 + number6 - number4;
                            qText = number1 + " - " + number2 + " + " + number6 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }

                    }
                    else if (shuffleAnswers == 1)
                    {
                        if (IntegerNum == 10)
                        {
                            questionAnswer3 = number1 - number2 - number3;
                            correctAnswer = questionAnswer1 = number1 - number2;
                            questionAnswer2 = number1 - number2 - number4;
                            qText = number1 + " - " + number2 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if ((IntegerNum == 15) || (IntegerNum == 25))
                        {
                            questionAnswer3 = number1 - number2 + number6 - number4;
                            correctAnswer = questionAnswer1 = number1 - number2 + number6;
                            questionAnswer2 = number1 - number2 + number6 - number3;
                            qText = number1 + " - " + number2 + "+ " + number6 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }

                    }
                    else if (shuffleAnswers == 2)

                    {
                        if (IntegerNum == 10)
                        {
                            questionAnswer2 = number1 - number2 - number4;
                            questionAnswer3 = number1 - number2 - number3;
                            correctAnswer = questionAnswer1 = number1 - number2;
                            qText = number1 + " - " + number2 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if ((IntegerNum == 15) || (IntegerNum == 25))
                        {
                            questionAnswer2 = number1 - number2 + number6 - number3;
                            questionAnswer3 = number1 - number2 + number6 - number4;
                            correctAnswer = questionAnswer1 = number1 - number2 + number6;
                            qText = number1 + " - " + number2 + " + " + number6 + " = ?";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                    }
                    break;
            }
        }

        TextBoxes(questionAnswer1, 0, questionNum);
        TextBoxes(questionAnswer2, 1, questionNum);
        TextBoxes(questionAnswer3, 2, questionNum);


        questionNum = questionNum + 1;
    }

    public void TextBoxes(int questionTextDisplay, int lane, int questionNum)
    {
        GameObject Answers = Instantiate(answerTextBox, new Vector3( lane * 3F, 5, transform.position.z + 180 * questionNum), Quaternion.identity);
         Answers.transform.position = new Vector3 (Answers.transform.position.x - 3, Answers.transform.position.y, Answers.transform.position.z);
        Answers.transform.Find("ANSWER").GetComponent<storedAnswers>().answerValues = questionTextDisplay;
        TextMeshPro VisualAnswers = Answers.GetComponentInChildren<TextMeshPro>();
        VisualAnswers.SetText(questionTextDisplay.ToString());
        questionParts.Add(Answers);
    }



}

