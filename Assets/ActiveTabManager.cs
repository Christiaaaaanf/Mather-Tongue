using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActiveTabManager : MonoBehaviour
{
    public List<Image> tabImgs;
    public List<TextMeshProUGUI> tabTexts;
    ActiveProfile activeProfile;

    public List<GameObject> LessonMenus;
    public List<GameObject> Menus;

    // Start is called before the first frame update
    void Start()
    {
        activeProfile = ActiveProfile.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if(ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek != -1)
        {
            foreach(GameObject menu in LessonMenus)
            {
                menu.SetActive(false);
            }

            foreach(GameObject menu in Menus)
            {
                menu.SetActive(false);
            }

            Menus[1].SetActive(true);

            switch (ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek)
            {
                case 1:
                case 2:
                case 3:
                    LessonMenus[0].SetActive(true);
                    break;
                case 4:
                case 5:
                    LessonMenus[1].SetActive(true);
                    break;
                case 6:
                case 7:
                    LessonMenus[2].SetActive(true);
                    break;
                case 8:
                case 9:
                    LessonMenus[3].SetActive(true);
                    break;
            }
        }
    }


    public void SetActiveTab(int index)
    {
        foreach(Image tab in tabImgs)
        {
            tab.color = new Color(0.72f, 0.72f, 0.82f);
        }

        foreach(TextMeshProUGUI tab in tabTexts)
        {
            tab.color = new Color(0.72f, 0.72f, 0.82f);
        }

        tabImgs[index].color = new Color(0.24f, 0.36f, 1.0f);
        tabTexts[index].color = new Color(0.24f, 0.36f, 1.0f);
    }
}
