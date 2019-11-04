using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Stc_Global
{
    public static classPlayer mainPlayer = new classPlayer(10, 2, 0.0f, 0.0f);
    public static classEnemy Enemy1 = new classEnemy(10, 2, 0.0f, 0.0f);
    public static classEnemy Enemy2 = new classEnemy(10, 2, 0.0f, 0.0f);
    public static classEnemy Enemy3 = new classEnemy(10, 2, 0.0f, 0.0f);

    public static bool inBattle = false;

   public static void startBattle(classPlayer p, classEnemy e1, classEnemy e2, classEnemy e3)
    {
        
    }
}
