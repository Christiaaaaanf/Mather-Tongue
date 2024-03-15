using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadLesson : MonoBehaviour
{
    public int targetSceneIndex;
    public List<GameObject> MenuScreens;
    public List<Button> LessonButton;
    public List<GameObject> LessonMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        
    }

    public void LoadTargetLesson(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }

    public void ShowMenu(GameObject Menu)
    {
        foreach (var menuScreen in MenuScreens)
        {
            menuScreen.SetActive(false);
        }

        Menu.SetActive(true);
    }

    public void ShowLesson(GameObject Menu)
    {
        foreach(var lesson in LessonMenu)
        {
            lesson.SetActive(false);
        }

        Menu.SetActive(true);
    }
}
