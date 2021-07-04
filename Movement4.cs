using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement4 : MonoBehaviour
{

    private Rigidbody2D rb2d;
    float start;
    // Use this for initialization
    void Start()
    {
        start = transform.position.y;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //pohyb WASD
        //D 
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
        //A
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        //pohyb šipky
        //pravá šipka
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
        //levá šipka
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
            
        }
        //pobyb konec
    }
    //skok
    private void OnTriggerStay2D(Collider2D collision)
    {
        float y = 500f;
        if (Input.GetKeyDown("space"))
        {
            rb2d.AddForce(new Vector2(0f, y));
        }
        if (Input.GetKeyDown("up"))
        {
            rb2d.AddForce(new Vector2(0f, y));
        }
    }

}
