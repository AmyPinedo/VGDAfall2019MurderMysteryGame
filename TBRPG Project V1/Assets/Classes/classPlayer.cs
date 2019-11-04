using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classPlayer : classEntity
{
    public classPlayer(int HP, int ATK, float CRITATK, float CRITPERC)
    {
        this.setHP(HP);
        this.setATK(ATK);
        this.setCritATK(CRITATK);
        this.setCritPerc(CRITPERC);
    }
}
