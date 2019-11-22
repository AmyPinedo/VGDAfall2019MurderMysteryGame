using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class sceneChangerReg : MonoBehaviour
{
    public void playButtonScene()
    {
        SceneManager.LoadScene(1);

    }

    public void playCreditsScene()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void endGameButton()
    {
        Application.Quit();
    }
}
