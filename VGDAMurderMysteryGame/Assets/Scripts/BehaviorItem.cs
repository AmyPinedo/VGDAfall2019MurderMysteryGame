using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorItem : MonoBehaviour
{
    public string name;
    public string desc;
    private GameObject playerObject;

    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnMouseDown()
    {
        playerObject.GetComponent<playerInventory>().playerInventoryVar.Add(new Item(name, null, desc));
        Object.Destroy(gameObject);
    }
}
