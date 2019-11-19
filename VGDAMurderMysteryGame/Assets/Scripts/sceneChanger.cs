using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class sceneChanger
{
    // Start is called before the first frame update
    public static void changeScene(string sceneName)
    {
        GameObject fadeBlack = GameObject.FindGameObjectWithTag("fadeBlack");
        fadeBlack.GetComponent<Animator>().Play("fadeBlackOut");
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        fadeBlack.GetComponent<Animator>().Play("fadeBlackIn");
    }
}
