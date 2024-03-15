using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EditProfile : MonoBehaviour
{
    public AvatarManager avatarManager;
    public TMP_InputField profileNameInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveEditProfile()
    {
        string profileName = profileNameInput.text;
        ActiveProfile.Instance.ProfileActive.PlayerName = profileName;
        ActiveProfile.Instance.ProfileActive.CurrentlyPlayingWeek = -1;
        ActiveProfile.Instance.ProfileActive.Avatar = avatarManager.SelectedSprite;

        string profileJson = JsonUtility.ToJson(ActiveProfile.Instance.ProfileActive);
        PlayerPrefs.SetString(ActiveProfile.Instance.ProfileKey, profileJson);
        PlayerPrefs.Save();
    }
}
