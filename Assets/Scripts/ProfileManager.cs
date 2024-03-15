using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProfileManager : MonoBehaviour
{
    public TMP_InputField profileNameInput;
    public List<TextMeshProUGUI> profileListText;
    public List<Image> profileListAvatar;
    public GameObject InputGM;
    public GameObject SelectUserGM;
    public GameObject MenuGM;
    public ActiveProfile ActiveProfile;
    public AvatarManager AvatarManager;

    public TextMeshProUGUI GreetText;
    public List<Image> AvatarDisplay;
    

    

    private readonly Slot slot = new();

    private const int maxProfiles = 3;


    // Start is called before the first frame update
    void Start()
    {
        ActiveProfile = ActiveProfile.Instance;
        LoadProfiles();

        if (ActiveProfile.ProfileKey != null && ActiveProfile.ProfileKey != "")
        {
            SelectUserGM.SetActive(false);
            MenuGM.SetActive(true);
        }
        else
        {
            SelectUserGM.SetActive(true);
            MenuGM.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey(ActiveProfile.ProfileKey))
        {
            GreetText.text = "Hi, " + ActiveProfile.ProfileActive.PlayerName + "!";

            foreach(Image image in AvatarDisplay)
            {
                image.sprite = ActiveProfile.ProfileActive.Avatar;
            }
        }
    }

    public void OnSlotClick(Slot slotGM)
    {
        string key = "Profile" + (slotGM.index + 1);

        // Check if the profile already exists
        if (PlayerPrefs.HasKey(key))
        {
            ActiveProfile.ProfileKey = key;
            ActiveProfile.ProfileActive = JsonUtility.FromJson<Profile>(PlayerPrefs.GetString(key));
            ActiveProfile.ProfileActive.CurrentlyPlayingWeek = -1;

            SelectUserGM.SetActive(false);
            MenuGM.SetActive(true);
            return;
        }


        slot.index = slotGM.index;
        InputGM.SetActive(true);
        SelectUserGM.SetActive(false);
    }

    public void CreateProfile()
    {
        string profileName = profileNameInput.text;

        if (string.IsNullOrEmpty(profileName))
        {
            Debug.LogWarning("Profile name cannot be empty!");
            return;
        }

        string key = "Profile" + (slot.index + 1);

        // Check if the profile already exists
        if (PlayerPrefs.HasKey(key))
        {
            Debug.LogWarning("Profile already exists in this slot!");
            return;
        }

        // Save the new profile
        Profile newProfile = new Profile(profileName);
        newProfile.Avatar = AvatarManager.SelectedSprite;
        string profileJson = JsonUtility.ToJson(newProfile);
        PlayerPrefs.SetString(key, profileJson);
        PlayerPrefs.Save();
        profileNameInput.text = "";

        // Update the profile list
        LoadProfiles();
        InputGM.SetActive(false);
        SelectUserGM.SetActive(true);
    }

    

    private void LoadProfiles()
    {
        for (int i = 0; i < maxProfiles; i++)
        {
            string key = "Profile" + (i + 1);

            // Check if the profile exists
            if (PlayerPrefs.HasKey(key))
            {
                string profileJson = PlayerPrefs.GetString(key);
                Profile profile = JsonUtility.FromJson<Profile>(profileJson);
                profileListText[i].text = profile.PlayerName;
                profileListAvatar[i].gameObject.SetActive(true);
                profileListAvatar[i].sprite = profile.Avatar;
            }
            else
            {
                profileListText[i].text = "Add Profile";
            }
        }
    }

    public void ResetProfile()
    {
        ActiveProfile.ProfileActive = null;
        ActiveProfile.ProfileKey = null;

        SceneManager.LoadScene(0);
    }
}
