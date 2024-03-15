using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Pause : MonoBehaviour
{
    public Button buttonToShow;

    private VideoPlayer videoPlayer;
    private bool isPaused = false;

    void Start()
    {
        //buttonToShow.interactable = false;
        // Get the VideoPlayer component attached to the GameObject
        videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.loopPointReached += EndReached;
    }

    void Update()
    {
        // Check for touch to pause/unpause the video
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (isPaused)
                {
                    // If video is paused, resume playback
                    videoPlayer.Play();
                    isPaused = false;
                }
                else
                {
                    // If video is playing, pause it
                    videoPlayer.Pause();
                    isPaused = true;
                }
            }
        }
    }

    private void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        // Show the button when the video ends
        if (buttonToShow != null)
        {
            buttonToShow.interactable = true;
        }
    }
}
