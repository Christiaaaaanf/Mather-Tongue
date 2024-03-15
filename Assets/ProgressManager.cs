using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : MonoBehaviour
{
    public GameObject PlayButtons;
    public GameObject LockedButtons;
    public int LessonNo;
    public bool IsLesson;
    public bool IsQuiz;
    public string WeekNumber;

    

    void Start()
    {
        ActiveProfile activeProfile = ActiveProfile.Instance;
        switch (WeekNumber)
        {
            case "Week1":
                if (IsQuiz)
                {
                    Debug.Log(activeProfile.ProfileActive.Lesson_1.Week[0]);

                    if (activeProfile.ProfileActive.Lesson_1.Week[0].Finished)
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                }

                if (IsLesson)
                {
                    PlayButtons.SetActive(true);
                    LockedButtons.SetActive(false);
                }
                break;
            case "Week2":
                if (IsQuiz)
                {
                    if (activeProfile.ProfileActive.Lesson_1.Week[1].Finished)
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                }

                if (IsLesson)
                {
                    if (activeProfile.ProfileActive.Lesson_1.Week[0].Finished && activeProfile.ProfileActive.Lesson_1.Week[0].Quiz > Mathf.RoundToInt(activeProfile.ProfileActive.Lesson_1.Week[0].QuizItemsCount / 2))
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                    
                }
                break;
            case "Week3":
                if (IsQuiz)
                {
                    if (activeProfile.ProfileActive.Lesson_1.Week[2].Finished)
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                }

                if (IsLesson)
                {
                    if (activeProfile.ProfileActive.Lesson_1.Week[1].Finished && activeProfile.ProfileActive.Lesson_1.Week[1].Quiz > Mathf.RoundToInt(activeProfile.ProfileActive.Lesson_1.Week[1].QuizItemsCount / 2))
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }

                }
                break;
            case "Week4":
                if (IsQuiz)
                {
                    if (activeProfile.ProfileActive.Lesson_2.Week[0].Finished)
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                }

                if (IsLesson)
                {
                    if (activeProfile.ProfileActive.Lesson_1.Week[2].Finished && activeProfile.ProfileActive.Lesson_1.Week[2].Quiz > Mathf.RoundToInt(activeProfile.ProfileActive.Lesson_1.Week[2].QuizItemsCount / 2))
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }

                }
                break;
            case "Week5":
                if (IsQuiz)
                {
                    if (activeProfile.ProfileActive.Lesson_2.Week[1].Finished)
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                }

                if (IsLesson)
                {
                    if (activeProfile.ProfileActive.Lesson_2.Week[0].Finished && activeProfile.ProfileActive.Lesson_2.Week[0].Quiz > Mathf.RoundToInt(activeProfile.ProfileActive.Lesson_2.Week[0].QuizItemsCount / 2))
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }

                }
                break;
            case "Week6":
                if (IsQuiz)
                {
                    if (activeProfile.ProfileActive.Lesson_3.Week[0].Finished)
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                }

                if (IsLesson)
                {
                    if (activeProfile.ProfileActive.Lesson_2.Week[1].Finished && activeProfile.ProfileActive.Lesson_2.Week[1].Quiz > Mathf.RoundToInt(activeProfile.ProfileActive.Lesson_2.Week[1].QuizItemsCount / 2))
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }

                }
                break;
            case "Week7":
                if (IsQuiz)
                {
                    if (activeProfile.ProfileActive.Lesson_3.Week[1].Finished)
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                }

                if (IsLesson)
                {
                    if (activeProfile.ProfileActive.Lesson_3.Week[0].Finished && activeProfile.ProfileActive.Lesson_3.Week[0].Quiz > Mathf.RoundToInt(activeProfile.ProfileActive.Lesson_3.Week[0].QuizItemsCount / 2))
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }

                }
                break;
            case "Week8":
                if (IsQuiz)
                {
                    if (activeProfile.ProfileActive.Lesson_4.Week[0].Finished)
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                }

                if (IsLesson)
                {
                    if (activeProfile.ProfileActive.Lesson_3.Week[1].Finished && activeProfile.ProfileActive.Lesson_3.Week[1].Quiz > Mathf.RoundToInt(activeProfile.ProfileActive.Lesson_3.Week[1].QuizItemsCount / 2))
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }

                }
                break;
            case "Week9":
                if (IsQuiz)
                {
                    if (activeProfile.ProfileActive.Lesson_4.Week[1].Finished)
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }
                }

                if (IsLesson)
                {
                    if (activeProfile.ProfileActive.Lesson_4.Week[0].Finished && activeProfile.ProfileActive.Lesson_4.Week[0].Quiz > Mathf.RoundToInt(activeProfile.ProfileActive.Lesson_4.Week[0].QuizItemsCount / 2))
                    {
                        PlayButtons.SetActive(true);
                        LockedButtons.SetActive(false);
                    }
                    else
                    {
                        PlayButtons.SetActive(false);
                        LockedButtons.SetActive(true);
                    }

                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
