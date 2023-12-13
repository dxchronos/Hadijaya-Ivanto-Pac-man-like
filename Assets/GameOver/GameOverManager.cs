using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Pac-Man Gameplay");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }
}
