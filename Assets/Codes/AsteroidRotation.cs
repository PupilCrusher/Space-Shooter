using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
    Rigidbody physic;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        physic = GetComponent<Rigidbody>();
        physic.angularVelocity = Random.insideUnitSphere * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
