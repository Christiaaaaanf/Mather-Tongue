using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public string displayAnswer;
    public TextMeshProUGUI textDisplayAnswer;
    public MultipleChoiceManager quizManager;
    public Color startcolor;
    public Button buttonNext;

    private void Awake()
    {
        startcolor = GetComponent<Image>().color;
        displayAnswer = "";
    }

    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("test2");
            Debug.Log(displayAnswer);
            textDisplayAnswer.text = displayAnswer;
            Debug.Log("Correct");
            quizManager.Correct();
            buttonNext.interactable = true;
        }

        else
        {
            GetComponent<Image>().color = Color.red;
            textDisplayAnswer.text = displayAnswer;
            Debug.Log("Wrong");
            quizManager.Wrong();
            buttonNext.interactable = true;
        }
    }
}
