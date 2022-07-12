using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBoom : MonoBehaviour
{
    public GameObject boom;
    public GameObject playerBoom;
    GameObject SpawnController ;
    SpawnControl controll;
    
     void Start()
    {
        SpawnController = GameObject.FindGameObjectWithTag("SpawnControll");
        controll = SpawnController.GetComponent<SpawnControl>();
        
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        Destroy(gameObject);
        Instantiate(boom, transform.position, transform.rotation);
        controll.scoreCounter(10);
        if (col.tag == "Player")
        {
            Instantiate(playerBoom, col.transform.position, col.transform.rotation);
            controll.gameOver();
        }
    }
    
        

}
