using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rb2d;
 
    bool isflying, pressedD = false, pressedA = false, pressedR = false, pressedL = false;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        isflying = false;

    }

    // Update is called once per frame
    void Update()
    {
        //pohyb WASD
        //D
        if (pressedR == false)
        {
            if (Input.GetKey("d"))
            {
                transform.Translate(Vector3.right * Time.deltaTime * 5);
                pressedD = true;
            }
        }
        //A
        if (pressedR == false)
        {
            if (Input.GetKey("a"))
            {
                transform.Translate(Vector3.left * Time.deltaTime * 5);
                pressedA = true;
            }
        }
        //pohyb šipky
        //pravá šipka
        if (pressedD == false)
        {
            if (Input.GetKey("right"))
            {
                transform.Translate(Vector3.right * Time.deltaTime * 5);
                pressedR = true;
            }
            }
        //levá šipka
        if (pressedA == false)
        {
          if (Input.GetKey("left"))
                {
                    transform.Translate(Vector3.left * Time.deltaTime * 5);
                    pressedL = true;
                }
        }
        if(Input.GetKeyUp("a"))
        {
            pressedA = false;
        }
        if (Input.GetKeyUp("d"))
        {
            pressedD = false;
        }
        if (Input.GetKeyUp("left"))
        {
            pressedL = false;
        }
        if (Input.GetKeyUp("right"))
        {
            pressedR = false;
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