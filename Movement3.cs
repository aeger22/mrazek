using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3 : MonoBehaviour {

	private Rigidbody2D rb2d;
    float start;
	// Use this for initialization
	void Start () {
        start = transform.position.y;
        rb2d = GetComponent <Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        //pohyb WASD
        //D 
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 3);
        }
        //A
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 3);
        }
        //pohyb šipky
        //pravá šipka
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 3);
        }
        //levá šipka
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 3);
        }
        //pobyb konec

        float y = 500f;
        float now = transform.position.y;
        //skok mezerník  
        if ((int)now == (int)start)
        {
            if (Input.GetKeyDown("space"))
            {
                rb2d.AddForce(new Vector2(0f, y));
            }
        }
        //skok šipka up  
        if ((int)now == (int)start)
        {
            if (Input.GetKeyDown("up"))
            {
                rb2d.AddForce(new Vector2(0f, y));
            }
        }
	}
}
