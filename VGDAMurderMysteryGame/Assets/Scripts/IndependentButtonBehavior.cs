using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndependentButtonBehavior : MonoBehaviour
{
    float x;
    float y;
    float z;
    // Start is called before the first frame update
    void Start()
    {
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float z = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(x, y, z);
    }
}
