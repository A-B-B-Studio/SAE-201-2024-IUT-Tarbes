using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;

    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);

    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
