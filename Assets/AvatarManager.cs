using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarManager : MonoBehaviour
{
    public Sprite[] avatarSources;
    public Image SelectedAvatar;

    public Sprite SelectedSprite;

    private int currentImageIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectedAvatar.sprite = avatarSources[0];
        SelectedSprite = avatarSources[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeAvatar(string direction)
    {
        if(direction == "Right")
        {
            currentImageIndex++;
                
            if(currentImageIndex >= avatarSources.Length)
            {
                currentImageIndex = 0;
            }
        }
        else if(direction == "Left")
        {
            currentImageIndex--;

            if (currentImageIndex < 0)
            {
                currentImageIndex = avatarSources.Length - 1;
            }
        }

        SelectedAvatar.sprite = avatarSources[currentImageIndex];
        SelectedSprite = avatarSources[currentImageIndex];
    }
}
