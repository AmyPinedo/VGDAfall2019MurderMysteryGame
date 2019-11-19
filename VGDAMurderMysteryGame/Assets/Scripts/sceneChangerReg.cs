using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneChangerReg : MonoBehaviour
{
    // Start is called before the first frame update
    public void playButtonScene()
    {
        Debug.Log("Button Works");
        sceneChanger.changeScene("Logan's Scene");
    }
}
