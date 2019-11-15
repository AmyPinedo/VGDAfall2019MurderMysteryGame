using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class nameTagBehavior : MonoBehaviour
{
    public GameObject parentObject;
    private float mheight;
    private float mwidth;

    private void Start()
    {
        mwidth = parentObject.GetComponent<BoxCollider2D>().bounds.size.x;
        mheight = parentObject.GetComponent<BoxCollider2D>().bounds.size.y;
        gameObject.GetComponent<TextMeshProUGUI>().text = parentObject.GetComponent<nameTagHave>().name;
    }
    private void Update()
    {
        transform.position = new Vector3(parentObject.transform.position.x, parentObject.transform.position.y + (mheight / 1.5f), 0.0f);
    }
}
