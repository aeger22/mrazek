using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    float x = 0;
    
   
	// Update is called once per frame
	void Update () {
        //pohyb WASD
        //D 
        if (Input.GetKey("d"))
        {
            x = x + Time.deltaTime * 5;
            transform.position = new Vector3(x, transform.position.y, 0);           
        }
        //A
        if (Input.GetKey("a"))
        {
            x = x - Time.deltaTime * 5;
            transform.position = new Vector3(x, transform.position.y, 0);      
        }
        //pohyb šipky
        //pravá šipka
        if (Input.GetKey("right"))
        {
            x = x + Time.deltaTime * 5;
            transform.position = new Vector3(x, transform.position.y, 0);
        }
        //lefá šipka
        if (Input.GetKey("left"))
        {
            x = x - Time.deltaTime * 5;
            transform.position = new Vector3(x, transform.position.y, 0);
        }
        //pobyb konec
        //skok mezerník
        if (Input.GetKeyDown("space"))
        { 
            float vyskaSkoku = transform.position.y;
            vyskaSkoku = vyskaSkoku + Time.deltaTime * 200;
            transform.position = new Vector3(transform.position.x, vyskaSkoku, 0);
        }
        //skok šipka up
        if (Input.GetKeyDown("up"))
        {
            float vyskaSkoku = transform.position.y;
            vyskaSkoku = vyskaSkoku + Time.deltaTime * 200;
            transform.position = new Vector3(transform.position.x, vyskaSkoku, 0);
        }
    }
}
