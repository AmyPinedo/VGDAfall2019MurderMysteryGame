using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BehaviorInventory : MonoBehaviour
{
    public static Queue<string> dialogueCurrent;
    public Button exitButton;
    private GameObject playerObject;
    private GameObject inventoryButtonObject;

    public TMP_Text item1TextName;
    public TMP_Text item1TextDesc;
    public TMP_Text item2TextName;
    public TMP_Text item2TextDesc;
    public TMP_Text item3TextName;
    public TMP_Text item3TextDesc;

    // Start is called before the first frame update
    void Start()
    {
        dialogueCurrent = new Queue<string>();
        playerObject = GameObject.FindGameObjectWithTag("Player");
        inventoryButtonObject = GameObject.FindGameObjectWithTag("inventoryButton");
        playerObject.GetComponent<PlayerMovement>().inventoryOpen = false;
    }

    public void Update()
    {
        if (playerObject.GetComponent<playerInventory>().playerInventoryVar.Count >= 1)
        {
            item1TextName.text = playerObject.GetComponent<playerInventory>().playerInventoryVar[0].itemName;
            item1TextDesc.text = playerObject.GetComponent<playerInventory>().playerInventoryVar[0].itemDesc;
        }
        if (playerObject.GetComponent<playerInventory>().playerInventoryVar.Count >= 2)
        {
            item2TextName.text = playerObject.GetComponent<playerInventory>().playerInventoryVar[1].itemName;
            item2TextDesc.text = playerObject.GetComponent<playerInventory>().playerInventoryVar[1].itemDesc;
        }
        if (playerObject.GetComponent<playerInventory>().playerInventoryVar.Count >= 3)
        {
            item3TextName.text = playerObject.GetComponent<playerInventory>().playerInventoryVar[2].itemName;
            item3TextDesc.text = playerObject.GetComponent<playerInventory>().playerInventoryVar[2].itemDesc;
        }

        if (playerObject.GetComponent<playerInventory>().playerInventoryVar.Count <= 0)
        {
            item1TextName.text = "";
            item1TextDesc.text = "";
            item2TextName.text = "";
            item2TextDesc.text = "";
            item3TextName.text = "";
            item3TextDesc.text = "";
        }
    }


    public void openInventory()
    {
        Debug.Log("Inventory Opened");
        inventoryButtonObject.gameObject.GetComponent<Animator>().Play("inventoryButtonExit");
        gameObject.GetComponent<Animator>().Play("inventoryEnter");
        playerObject.GetComponent<PlayerMovement>().inventoryOpen = true;
    }
   
    public void closeInventory()
    {
        Debug.Log("Inventory Closed");
        inventoryButtonObject.gameObject.GetComponent<Animator>().Play("inventoryButtonEnter");
        gameObject.GetComponent<Animator>().Play("inventoryExit");
        playerObject.GetComponent<PlayerMovement>().inventoryOpen = false;
    }
}
