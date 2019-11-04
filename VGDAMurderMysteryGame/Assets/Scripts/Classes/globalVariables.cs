using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class globalVariables
{
    public static List<Item> playerInventory = new List<Item>();
    public static bool menuOpen = false;
    public static inventory varInventory = GameObject.FindGameObjectWithTag("ItemInventory").GetComponent<inventory>();
<<<<<<< HEAD
}
=======

    public static float xPlayerMovement;
    public static float yPlayerMovement;
    }
>>>>>>> ec1d6b5da48f8b0e04f2b02eac56dc9aad982463
