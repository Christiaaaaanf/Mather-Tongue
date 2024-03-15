using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    public int WeekNo;
    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        switch (WeekNo)
        {
            case 1:
                ScoreText.text = ActiveProfile.Instance.ProfileActive.Lesson_1.Week[0].Quiz + "/" + ActiveProfile.Instance.ProfileActive.Lesson_1.Week[0].QuizItemsCount;
                break;
            case 2:
                ScoreText.text = ActiveProfile.Instance.ProfileActive.Lesson_1.Week[1].Quiz + "/" + ActiveProfile.Instance.ProfileActive.Lesson_1.Week[1].QuizItemsCount;
                break;
            case 3:
                ScoreText.text = ActiveProfile.Instance.ProfileActive.Lesson_1.Week[2].Quiz + "/" + ActiveProfile.Instance.ProfileActive.Lesson_1.Week[2].QuizItemsCount;
                break;

            case 4:
                ScoreText.text = ActiveProfile.Instance.ProfileActive.Lesson_2.Week[0].Quiz + "/" + ActiveProfile.Instance.ProfileActive.Lesson_2.Week[0].QuizItemsCount;
                break;
            case 5:
                ScoreText.text = ActiveProfile.Instance.ProfileActive.Lesson_2.Week[1].Quiz + "/" + ActiveProfile.Instance.ProfileActive.Lesson_2.Week[1].QuizItemsCount;
                break;

            case 6:
                ScoreText.text = ActiveProfile.Instance.ProfileActive.Lesson_3.Week[0].Quiz + "/" + ActiveProfile.Instance.ProfileActive.Lesson_3.Week[0].QuizItemsCount;
                break;
            case 7:
                ScoreText.text = ActiveProfile.Instance.ProfileActive.Lesson_3.Week[1].Quiz + "/" + ActiveProfile.Instance.ProfileActive.Lesson_3.Week[1].QuizItemsCount;
                break;

            case 8:
                ScoreText.text = ActiveProfile.Instance.ProfileActive.Lesson_4.Week[0].Quiz + "/" + ActiveProfile.Instance.ProfileActive.Lesson_4.Week[0].QuizItemsCount;
                break;
            case 9:
                ScoreText.text = ActiveProfile.Instance.ProfileActive.Lesson_4.Week[1].Quiz + "/" + ActiveProfile.Instance.ProfileActive.Lesson_4.Week[1].QuizItemsCount;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
