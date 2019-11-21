using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class sceneChangerReg : MonoBehaviour
{
    public void playButtonScene()
    {
        sceneChanger.changeScene("Final");
    }
}
