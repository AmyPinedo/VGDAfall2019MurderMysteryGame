using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;
    public Texture2D itemPicture;
    public string itemDesc;
    public ItemType typeOfItem;

    public Item(string name, Texture2D pic, string desc)
    {
        itemName = name;
        itemPicture = pic;
        itemDesc = desc;
    }

    public enum ItemType
    {
        Clue,
        UsableItem,
        Useless
    }
}
