using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Profile
{
    public string PlayerName;
    public Sprite Avatar;
    public int CurrentWeekProgress;
    public int CurrentlyPlayingWeek = -1;
    public int LastLessonPlayed;
    public Lesson Lesson_1; // Identifying Number
    public Lesson Lesson_2; // Addition
    public Lesson Lesson_3; // Subtracting
    public Lesson Lesson_4; // Subtracting


    public Profile(string playerName)
    {
        PlayerName = playerName;
        CurrentWeekProgress = 1;
        CurrentlyPlayingWeek = 0;

        LastLessonPlayed = 0;

        // Initialize Lesson_1
        Lesson_1 = new Lesson();
        Lesson_1.Week = new List<LessonDetails>(); // Initialize Week list for Lesson_1

        for (int i = 1; i <= 3; i++)
        {
            LessonDetails details = new LessonDetails();
            details.WeekNumber = "Week" + i;
            details.Finished = false;
            if (i < 3)
            {
                details.QuizItemsCount = 5;
            }
            else
            {
                details.QuizItemsCount = 12;
            }
            Lesson_1.Week.Add(details);
        }

        // Initialize Lesson_2
        Lesson_2 = new Lesson();
        Lesson_2.Week = new List<LessonDetails>(); // Initialize Week list for Lesson_2

        for (int i = 4; i <= 5; i++)
        {
            LessonDetails details = new LessonDetails();
            details.WeekNumber = "Week" + i;
            details.Finished = false;
            if (i < 5)
            {
                details.QuizItemsCount = 5;
            }
            else
            {
                details.QuizItemsCount = 12;
            }
            Lesson_2.Week.Add(details);
        }

        // Initialize Lesson_3
        Lesson_3 = new Lesson();
        Lesson_3.Week = new List<LessonDetails>(); // Initialize Week list for Lesson_3

        for (int i = 6; i <= 7; i++)
        {
            LessonDetails details = new LessonDetails();
            details.WeekNumber = "Week" + i;
            details.Finished = false;
            if (i < 7)
            {
                details.QuizItemsCount = 5;
            }
            else
            {
                details.QuizItemsCount = 12;
            }
            Lesson_3.Week.Add(details);
        }

        // Initialize Lesson_4
        Lesson_4 = new Lesson();
        Lesson_4.Week = new List<LessonDetails>(); // Initialize Week list for Lesson_4

        for (int i = 8; i <= 9; i++)
        {
            LessonDetails details = new LessonDetails();
            details.WeekNumber = "Week" + i;
            details.Finished = false;
            if (i < 9)
            {
                details.QuizItemsCount = 5;
            }
            else
            {
                details.QuizItemsCount = 15;
            }
            Lesson_4.Week.Add(details);
        }
    }
}

[Serializable]
public class Lesson
{
    public List<LessonDetails> Week;
}

[Serializable]
public class LessonDetails
{
    public string WeekNumber;
    public bool Finished;
    public int Quiz;
    public int QuizItemsCount;
}
