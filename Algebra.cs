using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Algebra : MonoBehaviour
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
        IntegerNum = MenuController.intensityForAlgebra;
        Debug.Log(IntegerNum);
        AlgebraQuestion();
    }

    // Update is called once per frame
    public void AlgebraQuestion()
    {
         foreach(GameObject previousQuestions in questionParts)
        {
            Destroy(previousQuestions);
        }

        questionParts = new List<GameObject>();


        int number1 = Random.Range(1, 7);
        int number1i = Random.Range(6, 12);


        int number2 = Mathf.FloorToInt(Random.value * IntegerNum);
        while (number2 == 0)
        {
            number2 = Mathf.FloorToInt(Random.value * IntegerNum);
        }
        int number3 = Mathf.FloorToInt(Random.value * IntegerNum);
        while (number3 == 0 || number3 == number2)
        {
            number3 = Mathf.FloorToInt(Random.value * IntegerNum);
        }

        // numbers 4 and 5 are two random numbers that are subtracted from te correctanswer to create two different  wrongAnswers.
        int number4 = Random.Range(-5, 5);
        while (number4 == 0)
        {
            number4 = Random.Range(-5, 5);
        }
         Debug.Log(number4);
        int number5 = Random.Range(-5, 5);
        while (number5 == 0 || number5 == number4)
        {
            number5 = Random.Range(-5, 5);
        }
        Debug.Log(number5);


        int questions = Mathf.FloorToInt(Random.value * 2);
        int shuffleAnswers = Mathf.FloorToInt(Random.Range(0, 3));

        if ((IntegerNum == 5) || (IntegerNum == 10))
        {
            switch (questions)
            {
                case 0:


                    if (shuffleAnswers == 0)
                    {
                        if (IntegerNum == 5)
                        {
                            correctAnswer = questionAnswer1 = (number1 * number3) / number1;
                            questionAnswer2 = ((number1 * number3) / number1) - number4;
                            questionAnswer3 = ((number1 * number3) / number1) - number5;
                            qText = number1 + " x - " + number2 + " = " + ((number1 * number3) - number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if (IntegerNum == 10)
                        {
                            correctAnswer = questionAnswer1 = (number1i * number3) / number1i;
                            questionAnswer2 = ((number1i * number3) / number1i) - number4;
                            questionAnswer3 = ((number1i * number3) / number1i) - number5;
                            qText = number1i + " x - " + number2 + " = " + ((number1i * number3) - number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }


                    }
                    else if (shuffleAnswers == 1)
                    {
                        if (IntegerNum == 5)
                        {
                            questionAnswer3 = ((number1 * number3) / number1) - number5;
                            correctAnswer = questionAnswer1 = (number1 * number3) / number1;
                            questionAnswer2 = ((number1 * number3) / number1) - number4;
                            qText = number1 + " x - " + number2 + " = " + ((number1 * number3) - number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if (IntegerNum == 10)
                        {
                            questionAnswer3 = ((number1i * number3) / number1i) - number5;
                            correctAnswer = questionAnswer1 = (number1i * number3) / number1i;
                            questionAnswer2 = ((number1i * number3) / number1i) - number4;
                            qText = number1i + " x - " + number2 + " = " + ((number1i * number3) - number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }


                    }
                    else if (shuffleAnswers == 2)
                    {

                        if (IntegerNum == 5)
                        {
                            questionAnswer2 = ((number1 * number3) / number1) - number4;
                            questionAnswer3 = ((number1 * number3) / number1) - number5;
                            correctAnswer = questionAnswer1 = (number1 * number3) / number1;
                            qText = number1 + " x - " + number2 + " = " + ((number1 * number3) - number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if (IntegerNum == 10)
                        {
                            questionAnswer2 = ((number1i * number3) / number1i) - number4;
                            questionAnswer3 = ((number1i * number3) / number1i) - number5;
                            correctAnswer = questionAnswer1 = (number1i * number3) / number1i;
                            qText = number1i + " x - " + number2 + " = " + ((number1i * number3) - number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                    }

                    break;

                case 1:

                    if (shuffleAnswers == 10)
                    {
                        if (IntegerNum == 5)
                        {
                            correctAnswer = questionAnswer1 = (number1 * number3) / number1;
                            questionAnswer2 = ((number1 * number3) / number1) - number4;
                            questionAnswer3 = ((number1 * number3) / number1) - number5;
                            qText = number1 + " x + " + number2 + " = " + ((number1 * number3) + number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if (IntegerNum == 10)
                        {
                            correctAnswer = questionAnswer1 = (number1i * number3) / number1i;
                            questionAnswer2 = ((number1i * number3) / number1i) - number4;
                            questionAnswer3 = ((number1i * number3) / number1i) - number5;
                            qText = number1i + " x + " + number2 + " = " + ((number1i * number3) + number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }

                    }
                    else if (shuffleAnswers == 1)
                    {
                        if (IntegerNum == 5)
                        {
                            questionAnswer3 = ((number1 * number3) / number1) - number5;
                            correctAnswer = questionAnswer1 = (number1 * number3) / number1;
                            questionAnswer2 = ((number1 * number3) / number1) - number4;
                            qText = number1 + " x + " + number2 + " = " + ((number1 * number3) + number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if (IntegerNum == 10)
                        {
                            questionAnswer3 = ((number1i * number3) / number1i) - number5;
                            correctAnswer = questionAnswer1 = (number1i * number3) / number1;
                            questionAnswer2 = ((number1i * number3) / number1i) - number4;
                            qText = number1i + " x + " + number2 + " = " + ((number1i * number3) + number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }

                    }
                    else if (shuffleAnswers == 2)
                    {
                        if (IntegerNum == 5)
                        {
                            questionAnswer2 = ((number1 * number3) / number1) - number4;
                            questionAnswer3 = ((number1 * number3) / number1) - number5;
                            correctAnswer = questionAnswer1 = (number1 * number3) / number1;
                            qText = number1 + " x + " + number2 + " = " + ((number1 * number3) + number2) + ".Find x.";
                            questionText.text = qText;
                            Debug.Log(qText);
                        }
                        else if (IntegerNum == 10)
                        {
                            questionAnswer2 = ((number1i * number3) / number1i) - number4;
                            questionAnswer3 = ((number1i * number3) / number1i) - number5;
                            correctAnswer = questionAnswer1 = (number1i * number3) / number1i;
                            qText = number1i + " x + " + number2 + " = " + ((number1i * number3) + number2) + ".Find x.";
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
         Answers.transform.position = new Vector3(Answers.transform.position.x - 3, Answers.transform.position.y, Answers.transform.position.z);
        Answers.transform.Find("ANSWER2").GetComponent<storedAnswers>().answerValues2 = questionTextDisplay;
        TextMeshPro VisualAnswers = Answers.GetComponentInChildren<TextMeshPro>();
        VisualAnswers.SetText(questionTextDisplay.ToString());
        questionParts.Add(Answers);
    }

}

