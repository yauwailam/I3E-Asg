using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class Jumpheight : Collectible

{
    public override void Collected(GameObject other)
    {
        Debug.Log(other.gameObject.GetComponent<FirstPersonController>());
        Debug.Log(other.gameObject.GetComponent<FirstPersonController>().JumpHeight);
        other.gameObject.GetComponent<FirstPersonController>().JumpHeight += 3.0f;
        base.Collected(other);


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
