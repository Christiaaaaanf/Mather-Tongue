using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccountButton : MonoBehaviour
{
    public GameObject Menu;
    ActiveProfile activeProfile;
    // Start is called before the first frame update
    void Start()
    {
        activeProfile = ActiveProfile.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
