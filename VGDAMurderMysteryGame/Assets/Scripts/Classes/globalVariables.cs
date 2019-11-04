using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class globalVariables
{
    public static List<Item> playerInventory = new List<Item>();
    public static bool menuOpen = false;
    public static inventory varInventory = GameObject.FindGameObjectWithTag("ItemInventory").GetComponent<inventory>();
}
