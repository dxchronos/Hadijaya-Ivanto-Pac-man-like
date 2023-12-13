using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Pac-Man Gameplay");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
