using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
/**
 * Item that will be stored in the player's inventory
 */
public class Item
{
    public string itemName;
    public Texture2D itemPicture;
    public string itemDesc;
    public ItemType typeOfItem;

    public enum ItemType
    {
        Clue,
        UsableItem,
        Useless
    }
}
