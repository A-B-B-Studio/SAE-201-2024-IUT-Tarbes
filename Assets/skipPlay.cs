using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipPlay : MonoBehaviour
{
    public string levelToLoad;

    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(levelToLoad);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
