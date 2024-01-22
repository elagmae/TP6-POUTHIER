using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        if (sceneName == "Jeu")
        {
            GameManager.Instance.score = 0;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
