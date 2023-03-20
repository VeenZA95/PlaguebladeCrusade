using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTiles : MonoBehaviour
{
    private float resetPosition = -27.9f;

    void Start()
    {
       
    }

   void Update()
    {
        if(transform.localPosition.x <= resetPosition)
        {
            Vector3 newPos = new Vector3(28f, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
