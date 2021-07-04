using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class enemyMovement : MonoBehaviour {

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 5);
    }
    int z = 180;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, z , transform.rotation.w);       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (z == 180)
            z = 0;
        else z = 180;
    }
}
