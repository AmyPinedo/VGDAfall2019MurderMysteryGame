using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    private GameObject playerObject;
    public List<Item> playerInventoryVar = new List<Item>();
    public inventory varInventory;

    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        varInventory = GameObject.FindGameObjectWithTag("ItemInventory").GetComponent<inventory>();
    }
    private void OnGUI()
    {
        ///Displays inventory when the menuOpen variable is true
        if(playerObject.GetComponent<PlayerMovement>().menuOpen == true)
        {
            for (int i = 0; i < playerInventoryVar.Count; i++)
            {
                GUI.Label(new Rect(10, i * 20, 200, 50), playerInventoryVar[i].itemName);
            }
        }
    }
}
