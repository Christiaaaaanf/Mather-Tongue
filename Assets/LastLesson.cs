using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastLesson : MonoBehaviour
{
    public TextMeshProUGUI LessonName;
    public TextMeshProUGUI WeekNo;

    private int BuildIndex;
    // Start is called before the first frame update
    void Start()
    {
        bool continueLoop = true;
        bool found = false;

        foreach (var week in ActiveProfile.Instance.ProfileActive.Lesson_1.Week)
        {
            LessonName.text = "Identifying Numbers";
            if (!continueLoop)
            {
                break;
            }
            switch (week.WeekNumber)
            {
                
                case "Week1":
                    if (!week.Finished)
                    {
                        WeekNo.text = "Week 1: Lesson 1";
                        BuildIndex = 1;
                    }
                    else if (week.Finished && (week.Quiz <= Mathf.Round(week.QuizItemsCount / 2)))
                    {
                        WeekNo.text = "Week 1: Exercise 1";
                        BuildIndex = 2;
                    }
                    else 
                    {
                        continue;
                    }

                    ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = 1;
                    continueLoop = false;
                    found = true;
                    break;
                case "Week2":
                    if (!week.Finished)
                    {
                        WeekNo.text = "Week 2: Lesson 2";
                        BuildIndex = 3;
                    }
                    else if (week.Finished && (week.Quiz <= Mathf.Round(week.QuizItemsCount / 2)))
                    {
                        WeekNo.text = "Week 2: Exercise 2";
                        BuildIndex = 4;
                    }
                    else
                    {
                        continue;
                    }

                    ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = 2;
                    continueLoop = false;
                    found = true;
                    break;
                case "Week3":
                    if (!week.Finished)
                    {
                        WeekNo.text = "Week 3: Lesson 3";
                        BuildIndex = 5;
                    }
                    else if (week.Finished && (week.Quiz <= Mathf.Round(week.QuizItemsCount / 2)))
                    {
                        WeekNo.text = "Week 3: Quiz";
                        BuildIndex = 6;
                    }
                    else
                    {
                        continue;
                    }

                    ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = 3;
                    continueLoop = false;
                    found = true;
                    break;
            }
        }

        if (!found)
        {
            foreach (var week in ActiveProfile.Instance.ProfileActive.Lesson_2.Week)
            {
                LessonName.text = "Adding Numbers";
                if (!continueLoop)
                {
                    break;
                }
                switch (week.WeekNumber)
                {

                    case "Week4":
                        if (!week.Finished)
                        {
                            WeekNo.text = "Week 4: Lesson 4";
                            BuildIndex = 7;
                        }
                        else if (week.Finished && (week.Quiz <= Mathf.Round(week.QuizItemsCount / 2)))
                        {
                            WeekNo.text = "Week 4: Exercise 1";
                            BuildIndex = 8;
                        }
                        else
                        {
                            continue;
                        }

                        ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = 4;
                        continueLoop = false;
                        found = true;
                        break;
                    case "Week5":
                        if (!week.Finished)
                        {
                            WeekNo.text = "Week 5: Lesson 5";
                            BuildIndex = 9;
                        }
                        else if (week.Finished && (week.Quiz <= Mathf.Round(week.QuizItemsCount / 2)))
                        {
                            WeekNo.text = "Week 5: Quiz";
                            BuildIndex = 10;
                        }
                        else
                        {
                            continue;
                        }

                        ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = 5;
                        continueLoop = false;
                        found = true;
                        break;
                }
            }
        }

        if (!found)
        {
            foreach (var week in ActiveProfile.Instance.ProfileActive.Lesson_3.Week)
            {
                LessonName.text = "Subtracting Numbers";
                if (!continueLoop)
                {
                    break;
                }
                switch (week.WeekNumber)
                {

                    case "Week6":
                        if (!week.Finished)
                        {
                            WeekNo.text = "Week 6: Lesson 6";
                            BuildIndex = 11;
                        }
                        else if (week.Finished && (week.Quiz <= Mathf.Round(week.QuizItemsCount / 2)))
                        {
                            WeekNo.text = "Week 6: Exercise 1";
                            BuildIndex = 12;
                        }
                        else
                        {
                            continue;
                        }

                        ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = 6;
                        continueLoop = false;
                        found = true;
                        break;
                    case "Week7":
                        if (!week.Finished)
                        {
                            WeekNo.text = "Week 7: Lesson 7";
                            BuildIndex = 13;
                        }
                        else if (week.Finished && (week.Quiz <= Mathf.Round(week.QuizItemsCount / 2)))
                        {
                            WeekNo.text = "Week 7: Quiz";
                            BuildIndex = 14;
                        }
                        else
                        {
                            continue;
                        }

                        ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = 7;
                        continueLoop = false;
                        found = true;
                        break;
                }
            }
        }

        if (!found)
        {
            foreach (var week in ActiveProfile.Instance.ProfileActive.Lesson_4.Week)
            {
                LessonName.text = "Multiplying Numbers";
                if (!continueLoop)
                {
                    break;
                }
                switch (week.WeekNumber)
                {

                    case "Week8":
                        if (!week.Finished)
                        {
                            WeekNo.text = "Week 8: Lesson 8";
                            BuildIndex = 15;
                        }
                        else if (week.Finished && (week.Quiz <= Mathf.Round(week.QuizItemsCount / 2)))
                        {
                            WeekNo.text = "Week 8: Exercise 1";
                            BuildIndex = 16;
                        }
                        else
                        {
                            continue;
                        }

                        ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = 8;
                        continueLoop = false;
                        found = true;
                        break;
                    case "Week9":
                        if (!week.Finished)
                        {
                            WeekNo.text = "Week 9: Lesson 9";
                            BuildIndex = 17;
                        }
                        else if (week.Finished && (week.Quiz <= Mathf.Round(week.QuizItemsCount / 2)))
                        {
                            WeekNo.text = "Week 9: Quiz";
                            BuildIndex = 18;
                        }
                        else
                        {
                            continue;
                        }

                        ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = 9;
                        continueLoop = false;
                        found = true;
                        break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToScene()
    {
        SceneManager.LoadScene(BuildIndex);
    }
}
