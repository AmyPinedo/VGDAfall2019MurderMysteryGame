using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public Item[] itemList;
    private int itemNumber;

    public Inventory()
    {
        itemList = new Item[10];
        itemNumber = 0;
    }

    public Item getItem(int index)
    {
        if (index >= 10)
        {
            return new Item("?", "?", null);
        }
        else
        {
            return itemList[index];
        }
    }

    public int addObject(Item newObject)
    {
        if (itemNumber >= 9)
        {
            return 0;
        }
        else
        {
            itemList[itemNumber] = newObject;
            itemNumber++;
            return 1;
        }
    }

    public int removeObject(int index)
    {
        if (itemNumber <= 0)
        {
            return 0;
        }
        else
        {
            for (int i = index; i < itemNumber; i++)
            {
                itemList[i] = itemList[i + 1];
            }
            itemList[itemNumber] = null;
            itemNumber--;
            return 1;
        }
    }
}
