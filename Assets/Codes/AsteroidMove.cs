using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody physic;
    public float speed;
    void Start()

    {
        physic = GetComponent<Rigidbody>();
        physic.velocity = transform.forward * speed;
    }
}
