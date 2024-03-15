using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Questions
{
    public string Question;
    public string[] Answers;
    public GameObject imageQuestion;
    public int CorrentAnswer;
    public AudioSource audio;
}
