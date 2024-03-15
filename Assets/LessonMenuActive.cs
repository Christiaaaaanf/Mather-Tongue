using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LessonMenuActive : MonoBehaviour
{
    public List<GameObject> Menus;
    public List<Image> tabImages;
    public List<TextMeshProUGUI> tabTexts;

    public GameObject Lesson;
    public Image LessonsTab;
    public TextMeshProUGUI LessonText;

    private void Awake()
    {
        foreach(GameObject menu in Menus)
        {
            menu.SetActive(false);
        }

        foreach(Image image in tabImages)
        {
            image.color = new Color(0.72f, 0.72f, 0.82f);
        }

        foreach(TextMeshProUGUI text in tabTexts)
        {
            text.color = new Color(0.72f, 0.72f, 0.82f);
        }

        LessonsTab.color = new Color(0.24f, 0.36f, 1.0f);
        LessonText.color = new Color(0.24f, 0.36f, 1.0f);
    }
}
