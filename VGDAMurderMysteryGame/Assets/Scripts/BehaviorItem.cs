using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorItem : MonoBehaviour
{
    public string name;
    public string desc;
    private Color basicColor = Color.white;
    private Color hoverColor = Color.grey;
    private SpriteRenderer renderer;
    private GameObject playerObject;

    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        renderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        playerObject.GetComponent<playerInventory>().playerInventoryVar.Add(new Item(name, null, desc));
        Object.Destroy(gameObject);
    }
    private void OnMouseEnter()
    {
        renderer.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        renderer.material.color = basicColor;
    }
}
