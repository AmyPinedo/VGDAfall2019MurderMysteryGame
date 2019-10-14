using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnGUI()
    {
        ///Displays inventory when the menuOpen variable is true
        if(globalVariables.menuOpen == true)
        {
            for (int i = 0; i < globalVariables.playerInventory.Count; i++)
            {
                GUI.Label(new Rect(10, i * 20, 200, 50), globalVariables.playerInventory[i].itemName);
            }
        }
    }
}
