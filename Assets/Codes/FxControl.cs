using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxControl : MonoBehaviour
{
    Rigidbody physic;
    public float speed;
    void Start()
        
    {
        physic = GetComponent<Rigidbody>();
        physic.velocity = transform.forward*speed;
    }

    // Update is called once per frame
   
}
