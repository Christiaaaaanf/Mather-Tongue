using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultipleChoiceManager : MonoBehaviour
{
    ActiveProfile activeProfile = ActiveProfile.Instance;
    public Button audioButton;
    public List<Questions> QnA;
    public GameObject[] options;
    public GameObject panelImage;

    public int currentQuestion;
    public int questionCounter = 0;
    public int score;
    public int quizNo;

    public GameObject QuizPanel;
    public GameObject QuizPassedPanel;
    public GameObject QuizFailedPanel;

    public GameObject[] imageQuestion;

    // public TextMeshProUGUI QuestionText;
    public TextMeshProUGUI QuestionCounter;
    public TextMeshProUGUI textAnswerReset;

    public TextMeshProUGUI quizScore;
    public TextMeshProUGUI quizScoreFailed;

    public Button[] buttonQuiz;
    public Button buttonNext;

    public Color startColor;

    public string quizTypeString;

    public int totalQnA;

    private bool isPlaying = false;

    private void Start()
    {
        totalQnA = QnA.Count;
        GenerateQuestion();
    }

    // Go back menu
    public void QuitQuiz()
    {
        SceneManager.LoadScene(0);
    }

    // End quiz
    void GameOver()
    {
        QuizPanel.SetActive(false);
        quizScore.SetText(score + "/" + totalQnA);
        quizScoreFailed.SetText(score + "/" + totalQnA);

        if (score > Mathf.RoundToInt(totalQnA / 2))
        {
            QuizPassedPanel.SetActive(true);
        }

        else {
            QuizFailedPanel.SetActive(true);
        }

        switch (quizNo)
        {
            case 1:
                if (score >= activeProfile.ProfileActive.Lesson_1.Week[0].Quiz)
                {
                    activeProfile.ProfileActive.Lesson_1.Week[0].Quiz = score;
                    PlayerPrefs.SetString(activeProfile.ProfileKey, JsonUtility.ToJson(activeProfile.ProfileActive));
                    PlayerPrefs.Save();
                }
                break;
            case 2:
                if (score >= activeProfile.ProfileActive.Lesson_1.Week[1].Quiz)
                {
                    activeProfile.ProfileActive.Lesson_1.Week[1].Quiz = score;
                    PlayerPrefs.SetString(activeProfile.ProfileKey, JsonUtility.ToJson(activeProfile.ProfileActive));
                    PlayerPrefs.Save();

                }
                break;
            case 3:
                if (score >= activeProfile.ProfileActive.Lesson_1.Week[2].Quiz)
                {
                    activeProfile.ProfileActive.Lesson_1.Week[2].Quiz = score;
                    PlayerPrefs.SetString(activeProfile.ProfileKey, JsonUtility.ToJson(activeProfile.ProfileActive));
                    PlayerPrefs.Save();

                }
                
                break;
            case 4:
                if (score >= activeProfile.ProfileActive.Lesson_2.Week[0].Quiz)
                {
                    activeProfile.ProfileActive.Lesson_2.Week[0].Quiz = score;
                    PlayerPrefs.SetString(activeProfile.ProfileKey, JsonUtility.ToJson(activeProfile.ProfileActive));
                    PlayerPrefs.Save();

                }
                break;
            case 5:
                if (score >= activeProfile.ProfileActive.Lesson_2.Week[1].Quiz)
                {
                    activeProfile.ProfileActive.Lesson_2.Week[1].Quiz = score;
                    PlayerPrefs.SetString(activeProfile.ProfileKey, JsonUtility.ToJson(activeProfile.ProfileActive));
                    PlayerPrefs.Save();

                }
                break;
            case 6:
                if (score >= activeProfile.ProfileActive.Lesson_3.Week[0].Quiz)
                {
                    activeProfile.ProfileActive.Lesson_3.Week[0].Quiz = score;
                    PlayerPrefs.SetString(activeProfile.ProfileKey, JsonUtility.ToJson(activeProfile.ProfileActive));
                    PlayerPrefs.Save();

                }
                break;
            case 7:
                if (score >= activeProfile.ProfileActive.Lesson_3.Week[1].Quiz)
                {
                    activeProfile.ProfileActive.Lesson_3.Week[1].Quiz = score;
                    PlayerPrefs.SetString(activeProfile.ProfileKey, JsonUtility.ToJson(activeProfile.ProfileActive));
                    PlayerPrefs.Save();

                }
                

                break;
            case 8:
                if (score >= activeProfile.ProfileActive.Lesson_4.Week[0].Quiz)
                {
                    activeProfile.ProfileActive.Lesson_4.Week[0].Quiz = score;
                    PlayerPrefs.SetString(activeProfile.ProfileKey, JsonUtility.ToJson(activeProfile.ProfileActive));
                    PlayerPrefs.Save();

                }
                

                break;
            case 9:
                if (score >= activeProfile.ProfileActive.Lesson_4.Week[1].Quiz)
                {
                    activeProfile.ProfileActive.Lesson_4.Week[1].Quiz = score;
                    PlayerPrefs.SetString(activeProfile.ProfileKey, JsonUtility.ToJson(activeProfile.ProfileActive));
                    PlayerPrefs.Save();

                }
                

                break;
            default:
                break;
        }
    }

    // Correct answer
    public void Correct()
    {
        PauseAllAudio();
        score += 1;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());

    }

    // Wrong answer
    public void Wrong()
    {
        PauseAllAudio();
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());
        
    }

    // Set answers for  question
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<Answers>().startcolor;
            options[i].GetComponent<Answers>().isCorrect = false;
            options[i].GetComponent<Answers>().displayAnswer = QnA[currentQuestion].Answers[i];
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrentAnswer == i + 1)
            {
                options[i].GetComponent<Image>().color = options[i].GetComponent<Answers>().startcolor;
                options[i].GetComponent<Answers>().displayAnswer = QnA[currentQuestion].Answers[i];
                Debug.Log(options[i].GetComponent<Answers>().displayAnswer = QnA[currentQuestion].Answers[i]);
                options[i].GetComponent<Answers>().isCorrect = true;
            }
        }
    }

    // Generate question
    void GenerateQuestion()
    {
        
        buttonQuiz[0].interactable = true;
        buttonQuiz[1].interactable = true;
        buttonQuiz[2].interactable = true;
        buttonQuiz[3].interactable = true;
        buttonQuiz[4].interactable = true;
        questionCounter += 1;
        QuestionCounter.SetText(questionCounter.ToString() + "/" + totalQnA);
        buttonNext.interactable = false;


        
        if (QnA.Count > 0)
        {
            currentQuestion = UnityEngine.Random.Range(0, QnA.Count);

            foreach(GameObject gm in imageQuestion)
            {
                gm.SetActive(false);
            }

            // QuestionText.text = QnA[currentQuestion].Question;
            QnA[currentQuestion].imageQuestion.SetActive(true);

            SetAnswers();
        }

        else
        {
            Debug.Log("No more questions.");
            GameOver();
        }
    }

    // Show next question
    public void NextQuestion()
    {
        
        GenerateQuestion();
        textAnswerReset.text = "";
        // imageQuestion[6].SetActive(false);
        // imageQuestion[7].SetActive(false);
        // imageQuestion[8].SetActive(false);
        // imageQuestion[9].SetActive(false);
        // imageQuestion[10].SetActive(false);
        // imageQuestion[11].SetActive(false);
    }

    // Wait for 1 Second
    IEnumerator WaitForNext()
    {
        buttonQuiz[0].interactable = false;
        buttonQuiz[1].interactable = false;
        buttonQuiz[2].interactable = false;
        buttonQuiz[3].interactable = false;
        buttonQuiz[4].interactable = false;
        yield return new WaitForSeconds(1);
    }

    public void ToggleAudio()
    {
        
        if (isPlaying)
        {
            QnA[currentQuestion].audio.Pause();
            isPlaying = false;
            audioButton.image.color = new Color(1, 0, 0, 1);
        }
        else
        {
            QnA[currentQuestion].audio.Play();
            isPlaying = true;
            audioButton.image.color = new Color(1, 1, 1, 1);
        }
    }

    private void PauseAllAudio()
    {
        isPlaying = false;
        audioButton.image.color = new Color(1, 0, 0, 1);
        foreach (Questions qna in QnA)
        {
            qna.audio.Stop();
        }
    }
}

