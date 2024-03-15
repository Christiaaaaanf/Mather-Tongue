using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    public GameObject progressMeter;
    public TextMeshProUGUI progressText;
    public int LessonNo;
    ActiveProfile activeProfile;

    // Start is called before the first frame update
    void Start()
    {
        activeProfile = ActiveProfile.Instance;
        float percent = GetLessonProgress();
        progressText.text = ((float)Math.Round(percent * 100f, 0)).ToString() + "%";

        RectTransform rectTransform = progressMeter.GetComponent<RectTransform>();
        RectTransform parentRectTransform = progressMeter.transform.parent.GetComponent<RectTransform>();
        float targetRight = parentRectTransform.rect.width * percent;
        rectTransform.offsetMax = new Vector2(-parentRectTransform.rect.width + targetRight, rectTransform.offsetMax.y);
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetLessonProgress()
    {
        int total = 0;
        int finished = 0;
        switch (LessonNo)
        {
            case 1:
                total = activeProfile.ProfileActive.Lesson_1.Week.Count * 2;
                foreach (var week in activeProfile.ProfileActive.Lesson_1.Week)
                {
                    if (week.Finished)
                    {
                        finished++;
                    }

                    if (week.Quiz > Mathf.Round(week.QuizItemsCount / 2))
                    {
                        finished++;
                    }
                }
                break;
            case 2:
                total = activeProfile.ProfileActive.Lesson_2.Week.Count * 2;
                foreach (var week in activeProfile.ProfileActive.Lesson_2.Week)
                {
                    if (week.Finished)
                    {
                        finished++;
                    }

                    if (week.Quiz > Mathf.Round(week.QuizItemsCount / 2))
                    {
                        finished++;
                    }
                }
                break;
            case 3:
                total = activeProfile.ProfileActive.Lesson_3.Week.Count * 2;
                foreach (var week in activeProfile.ProfileActive.Lesson_3.Week)
                {
                    if (week.Finished)
                    {
                        finished++;
                    }

                    if (week.Quiz > Mathf.Round(week.QuizItemsCount / 2))
                    {
                        finished++;
                    }
                }
                break;
            case 4:
                total = activeProfile.ProfileActive.Lesson_4.Week.Count * 2;
                foreach (var week in activeProfile.ProfileActive.Lesson_4.Week)
                {
                    if (week.Finished)
                    {
                        finished++;
                    }

                    if (week.Quiz > Mathf.Round(week.QuizItemsCount / 2))
                    {
                        finished++;
                    }
                }
                break;
            default:
                total = (activeProfile.ProfileActive.Lesson_1.Week.Count * 2) + (activeProfile.ProfileActive.Lesson_2.Week.Count * 2) + (activeProfile.ProfileActive.Lesson_3.Week.Count * 2) + (activeProfile.ProfileActive.Lesson_4.Week.Count * 2);
                foreach (var week in activeProfile.ProfileActive.Lesson_1.Week)
                {
                    if (week.Finished)
                    {
                        finished++;
                    }

                    if (week.Quiz > Mathf.Round(week.QuizItemsCount / 2))
                    {
                        finished++;
                    }
                }
                foreach (var week in activeProfile.ProfileActive.Lesson_2.Week)
                {
                    if (week.Finished)
                    {
                        finished++;
                    }

                    if (week.Quiz > Mathf.Round(week.QuizItemsCount / 2))
                    {
                        finished++;
                    }
                }
                foreach (var week in activeProfile.ProfileActive.Lesson_3.Week)
                {
                    if (week.Finished)
                    {
                        finished++;
                    }

                    if (week.Quiz > Mathf.Round(week.QuizItemsCount / 2))
                    {
                        finished++;
                    }
                }
                foreach (var week in activeProfile.ProfileActive.Lesson_4.Week)
                {
                    if (week.Finished)
                    {
                        finished++;
                    }

                    if (week.Quiz > Mathf.Round(week.QuizItemsCount / 2))
                    {
                        finished++;
                    }
                }
                break;
        }

        

        return (float)finished / (float)total;

    }
}
