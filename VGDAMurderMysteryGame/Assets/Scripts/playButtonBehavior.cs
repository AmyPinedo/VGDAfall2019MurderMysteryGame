using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playButtonBehavior : MonoBehaviour
{
    private void OnMouseDown()
    {
        sceneChanger.changeScene("Logan's Scene");
    }
}
