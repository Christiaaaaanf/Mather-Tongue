using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLesson : MonoBehaviour
{
    [SerializeField]
    
    public int indexScene;
    public int week;

    ActiveProfile activeProfile;

    // Start is called before the first frame update
    void Start()
    {
        activeProfile = ActiveProfile.Instance;
        
        // Get the EventTrigger component attached to the GameObject
        EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();

        // Create a new entry for the PointerClick event
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) => { OnPointerClick((PointerEventData)data); });

        // Add the entry to the EventTrigger component
        eventTrigger.triggers.Add(entry);
    }

    private void OnPointerClick(PointerEventData data)
    {
        if (PlayerPrefs.HasKey(activeProfile.ProfileKey))
        {
            activeProfile.ProfileActive.CurrentlyPlayingWeek = week;
            SceneManager.LoadScene(indexScene);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
