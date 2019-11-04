using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Int_Entity
{
    int getHP();
    void setHP(int i);
    int getATK();
    void setATK(int i);
    float getCritATK();
    void setCritATK(float f);
    float getCritPerc();
    void setCritPerc(float f);
}
