using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class IntIntUnityEvent : UnityEvent<int, int> { }
public class ActiveProfile : MonoBehaviour
{

    public static ActiveProfile Instance;

    public string ProfileKey;
    [SerializeField]
    public Profile ProfileActive;

    public string LastLessonSelected = null;


    public IntIntUnityEvent OnLoadTargetLesson;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        
    }

    
}
