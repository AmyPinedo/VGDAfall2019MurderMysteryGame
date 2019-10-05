using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private string mname;
    private string mdesc;
    public Sprite itemSprite;

    public Item(string name, string desc, Sprite sprite)
    {
        mname = name;
        mdesc = desc;
        itemSprite = sprite;
    }

    public string getName()
    {
        return mname;
    }

    public string getdesc()
    {
        return mdesc;
    }
}
