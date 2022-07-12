using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody physic;
    float horizontal    =   0;
    float vertical = 0;
    Vector3 vec;
    public float characterSpeed = 4;
    public float slop;
     float firingTime = 0 ;
    public float firingCoolDown ;
    public GameObject laser;
    public Transform LaserGunPosition;
     AudioSource audio;
    void Start()
    {
        physic = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {

        if (Input.GetButton("Fire1") && Time.time > firingTime )
        {
            firingTime = Time.time + firingCoolDown;
            Instantiate(laser, LaserGunPosition.position, Quaternion.identity);
            audio.Play();

        }
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(horizontal, 0, vertical);
        physic.velocity=vec * characterSpeed;
        physic.position = new Vector3(
            Mathf.Clamp(physic.position.x, -6f,6f ),
            0.0f,
            Mathf.Clamp(physic.position.y, 0, 0)
            );
        physic.rotation = Quaternion.Euler(0, 0, physic.velocity.x*-slop);
    }
}
