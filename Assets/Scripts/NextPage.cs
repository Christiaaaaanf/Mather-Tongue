using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class NextPage : MonoBehaviour
{
    public List<GameObject> LessonImages;
    public List<string> Texts;
    public TextMeshProUGUI LessonText;
    public TextMeshProUGUI ButtonText;
    public TextMeshProUGUI CounterText;
    public int Counter = 1;
    public int MaxPageCount;
    public int CurrentLessonNumber;

    private bool isPlaying = false;
    public List<AudioSource> audioSource;
    public Button audioButton;
    public Color playingColor = new Color(1, 1, 1, 1);
    public Color pausedColor = new Color(1, 0, 0, 1);

    ActiveProfile activeProfile = ActiveProfile.Instance;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject gm in LessonImages)
        {
            gm.SetActive(false);
        }

        LessonImages[Counter - 1].SetActive(true);
        LessonText.text = Texts[Counter - 1];
        CounterText.text = Counter + "/" + MaxPageCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoNextPage()
    {
        Counter++;
        if (Counter < MaxPageCount)
        {
            
            foreach (GameObject gm in LessonImages)
            {
                gm.SetActive(false);
            }

            LessonImages[Counter - 1].SetActive(true);
            LessonText.text = Texts[Counter - 1];
            CounterText.text = Counter + "/" + MaxPageCount;
        }
        else if(Counter == MaxPageCount)
        {
            foreach (GameObject gm in LessonImages)
            {
                gm.SetActive(false);
            }

            LessonImages[Counter - 1].SetActive(true);
            LessonText.text = Texts[Counter - 1];
            CounterText.text = Counter + "/" + MaxPageCount;
            ButtonText.text = "FINISH";
        }
        else
        {
            if (CurrentLessonNumber >= 8 && CurrentLessonNumber <= 9)
            {
                activeProfile.ProfileActive.Lesson_4.Week[CurrentLessonNumber - 8].Finished = true;
            }

            if (CurrentLessonNumber >= 6 && CurrentLessonNumber <= 7)
            {
                activeProfile.ProfileActive.Lesson_3.Week[CurrentLessonNumber - 6].Finished = true;
            }

            if (CurrentLessonNumber >= 4 && CurrentLessonNumber <= 5)
            {
                activeProfile.ProfileActive.Lesson_2.Week[CurrentLessonNumber - 4].Finished = true;
            }

            if (CurrentLessonNumber >= 1 && CurrentLessonNumber <= 3)
            {
                activeProfile.ProfileActive.Lesson_1.Week[CurrentLessonNumber - 1].Finished = true;
            }

            string profileJson = JsonUtility.ToJson(activeProfile.ProfileActive);
            PlayerPrefs.SetString(activeProfile.ProfileKey, profileJson);
            PlayerPrefs.Save();

            SceneManager.LoadScene(0);
        }
        PauseAllAudio();
    }

    public void ToggleAudio()
    {
        if (isPlaying)
        {
            PauseAudio();
        }
        else
        {
            PlayAudio();
        }
    }

    private void PlayAudio()
    {
        audioSource[Counter - 1].Play();
        isPlaying = true;
        Debug.Log("Playing...");
        audioButton.image.color = playingColor;
    }

    private void PauseAudio()
    {
        audioSource[Counter - 1].Pause();
        isPlaying = false;
        Debug.Log("Paused.");
        audioButton.image.color =  pausedColor;
    }

    private void PauseAllAudio()
    {
        isPlaying = false;
        audioButton.image.color = pausedColor;
        foreach (var audio in audioSource)
        {
            audio.Stop();
        }
    }
}

