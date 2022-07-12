using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageColl : MonoBehaviour
{
    //BURAYA BAKICAN
    private void OnTriggerEnter(Collider col)
    {
       
        {
            Destroy(col.gameObject);
        }
    }

}
