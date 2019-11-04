using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class classEntity : Int_Entity
{
    private int playerHP;
    private int playerATK;
    private float playerCritPerc;
    private float playerCritATK;

    public int getHP()
    {
        return playerHP;
    }

    public void setHP(int i)
    {
        playerHP = i;
    }

    public int getATK()
    {
        return playerATK;
    }

    public void setATK(int i)
    {
        playerATK = i;
    }

    public float getCritPerc()
    {
        return playerCritPerc;
    }

    public void setCritPerc(float i)
    {
        playerCritPerc = i;
    }

    public float getCritATK()
    {
        return playerCritATK;
    }

    public void setCritATK(float i)
    {
        playerCritATK = i;
    }
}
