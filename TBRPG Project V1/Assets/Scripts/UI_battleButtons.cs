using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_battleButtons : MonoBehaviour
{
    private void Update()
    {
        
    }

    public void attackEnemy1()
    {
        Stc_Global.Enemy1.setHP(Stc_Global.Enemy1.getHP() - Stc_Global.mainPlayer.getATK());
    }

    public void attackEnemy2()
    {
        Stc_Global.Enemy2.setHP(Stc_Global.Enemy2.getHP() - Stc_Global.mainPlayer.getATK());
    }

    public void attackEnemy3()
    {
        Stc_Global.Enemy3.setHP(Stc_Global.Enemy3.getHP() - Stc_Global.mainPlayer.getATK());
    }

    private void OnGUI()
    {
        GUI.TextArea(new Rect(10, 10, Stc_Global.mainPlayer.getHP().ToString().Length * 15, 20), Stc_Global.mainPlayer.getHP().ToString(), 200);
        GUI.TextArea(new Rect(100, 10, Stc_Global.Enemy1.getHP().ToString().Length * 15, 20), Stc_Global.Enemy1.getHP().ToString(), 200);
        GUI.TextArea(new Rect(200, 10, Stc_Global.Enemy2.getHP().ToString().Length * 15, 20), Stc_Global.Enemy2.getHP().ToString(), 200);
        GUI.TextArea(new Rect(300, 10, Stc_Global.Enemy3.getHP().ToString().Length * 15, 20), Stc_Global.Enemy3.getHP().ToString(), 200);
    }
}
