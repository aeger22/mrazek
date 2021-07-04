using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement5 : MonoBehaviour
{

    private Rigidbody2D rb2d;
    float start;
    bool isflying;
    // Use this for initialization
    void Start()
    {
        start = transform.position.y;
        rb2d = GetComponent<Rigidbody2D>();
        isflying = false;
     
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
        
        if (isflying == false)
        {
            float y = 500f;
                if (Input.GetKeyDown("space"))
                {
                    rb2d.AddForce(new Vector2(0f, y));
                    isflying = true;
                }
                if (Input.GetKeyDown("up"))
                {
                    rb2d.AddForce(new Vector2(0f, y));
                    isflying = true;
                }
        }
        
    }


    //skok
    private void OnTriggerStay2D(Collider2D collision)
    {
        isflying = false; 
    }
    

}
