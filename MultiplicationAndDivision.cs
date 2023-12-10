using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultiplicationAndDivision : MonoBehaviour
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
        IntegerNum = MenuController.intensityForDivisionAndMultiplication;
        Debug.Log(IntegerNum);
        MultiplicatingAndDivision();
    }

    // Update is called once per frame
    public void MultiplicatingAndDivision()
    {
         foreach(GameObject previousQuestions in questionParts)
        {
            Destroy(previousQuestions);
        }

        questionParts = new List<GameObject>();

        // number1 and number2 is part of the questions generated in level 1 multiplication and division
        int number1 = Random.Range(2, IntegerNum);
        while (number1 == 0)
        {
            number1 = Random.Range(2, IntegerNum);
        }
        int number2 = Random.Range(2, IntegerNum);
        while (number2 == 0 || number2 == number1)
        {
            number2 = Random.Range(2, IntegerNum);
        }

        int number3 = Random.Range(-5, 5);
        while (number3 == 0)
        {
            number3 = Random.Range(-5, 5);
        }
        Debug.Log(number3);
        int number4 = Random.Range(-5, 5);
        while (number4 == 0 || number3 == number4)
        {
            number4 = Random.Range(-5, 5);
        }
        Debug.Log(number4);

        int questions = Mathf.FloorToInt(Random.value * 2);
        int shuffleAnswers = Mathf.FloorToInt(Random.Range(0, 3));

        if ((IntegerNum == 4) || (IntegerNum == 8) || (IntegerNum == 12))

            switch (questions)
            {
                case 0:

                    if (shuffleAnswers == 0)
                    {
                        if ((IntegerNum == 4) || (IntegerNum == 8) || (IntegerNum == 12))
                        {
                            correctAnswer = questionAnswer1 = (number1 * number2);
                            questionAnswer2 = (number1 * number2) - number3;
                            questionAnswer3 = (number1 * number2) - number4;
                            qText = number1 + " x " + number2 + "= ?";
                            Debug.Log(qText);
                            questionText.text = qText;
                        }

                    }

                    else if (shuffleAnswers == 1)
                    {
                        if ((IntegerNum == 4) || (IntegerNum == 8) || (IntegerNum == 12))
                        {
                            questionAnswer3 = (number1 * number2) - number4;
                            correctAnswer = questionAnswer1 = (number1 * number2);
                            questionAnswer2 = (number1 * number2) - number3;
                            qText = number1 + " x " + number2 + "= ?";
                            Debug.Log(qText);
                            questionText.text = qText;

                        }
                    }
                    else if (shuffleAnswers == 2)
                    {
                        if ((IntegerNum == 4) || (IntegerNum == 8) || (IntegerNum == 12))
                        {
                            questionAnswer2 = (number1 * number2) - number3;
                            questionAnswer3 = (number1 * number2) - number4;
                            correctAnswer = questionAnswer1 = (number1 * number2);
                            qText = number1 + " x " + number2 + "= ?";
                            Debug.Log(qText);
                            questionText.text = qText;
                        }

                    }

                    break;

                case 1:

                    if (shuffleAnswers == 0)
                    {
                        if ((IntegerNum == 4) || (IntegerNum == 8) || (IntegerNum == 12))
                        {

                            questionAnswer1 = correctAnswer = number1;
                            questionAnswer2 = number1 - number3;
                            questionAnswer3 = number1 - number4;
                            qText = (number1 * number2) + "/" + number2 + "= ?";
                            Debug.Log(qText);
                            questionText.text = qText;

                        }
                    }

                    else if (shuffleAnswers == 1)
                    {
                        if ((IntegerNum == 4) || (IntegerNum == 8) || (IntegerNum == 12))
                        {
                            questionAnswer3 = number1 - number4;
                            questionAnswer1 = correctAnswer = number1;
                            questionAnswer2 = number1 - number3;
                            qText = (number1 * number2) + "/" + number2 + "= ?";
                            Debug.Log(qText);
                            questionText.text = qText;

                        }
                    }
                    else if (shuffleAnswers == 2)
                    {
                        if ((IntegerNum == 4) || (IntegerNum == 8) || (IntegerNum == 12))
                        {

                            questionAnswer2 = number1 - number3;
                            questionAnswer3 = number1 - number4;
                            questionAnswer1 = correctAnswer = number1;
                            qText = (number1 * number2) + "/" + number2 + "= ?";
                            Debug.Log(qText);
                            questionText.text = qText;

                        }

                    }

                    break;
            }
        TextBoxes(questionAnswer1, 0, questionNum);
        TextBoxes(questionAnswer2, 1, questionNum);
        TextBoxes(questionAnswer3, 2, questionNum);

    }

    public void TextBoxes(int questionTextDisplay, int lane, int questionNum)
    {
        GameObject Answers = Instantiate(answerTextBox, new Vector3( lane * 3F, 5, transform.position.z + 180 * questionNum), Quaternion.identity);
        Answers.transform.position = new Vector3(Answers.transform.position.x - 3, Answers.transform.position.y, Answers.transform.position.z);
        Answers.transform.Find("ANSWER1").GetComponent<storedAnswers>().answerValues1= questionTextDisplay;
        TextMeshPro VisualAnswers = Answers.GetComponentInChildren<TextMeshPro>();
        VisualAnswers.SetText(questionTextDisplay.ToString());
        questionParts.Add(Answers);
    }
}

