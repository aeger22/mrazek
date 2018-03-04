using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
	
		rb2d = GetComponent <Rigidbody2D>();
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

		float y = 500f;

		//skok mezerník
		if (Input.GetKeyDown("space"))
		{
			rb2d.AddForce(new Vector2 (0f, y) );
		}
		if (Input.GetKeyUp("space"))
		{
			
		}
		//skok šipka up
		if (Input.GetKeyDown("up"))
		{
			rb2d.AddForce(new Vector2 (0f, y) );
		}
		if (Input.GetKeyUp("up"))
		{
			
		}
	}
}
