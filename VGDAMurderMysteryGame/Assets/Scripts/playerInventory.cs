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
}
