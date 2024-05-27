using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movespeed : Collectible
{
    public override void Collected(GameObject other)
    {
        Debug.Log(other.gameObject.GetComponent<FirstPersonController>());
        Debug.Log(other.gameObject.GetComponent<FirstPersonController>().MoveSpeed);
        other.gameObject.GetComponent<FirstPersonController>().MoveSpeed += 15.0f;
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
