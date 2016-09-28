using UnityEngine;
using System.Collections;

public class MazeMovement : MonoBehaviour
{
    private float speed = 80f;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



        rb.velocity = new Vector2(0,0);

        Vector2 tempVel = rb.velocity;

        if (Input.GetKey("d"))
        {
            tempVel.x = -speed;
        }

        if (Input.GetKey("a"))
        {
            tempVel.x = speed;
        }

        if (Input.GetKey("w"))
        {
            tempVel.y = -speed;
        }

        if (Input.GetKey("s"))
        {
            tempVel.y = speed;
        }

        rb.velocity = tempVel;

    }


}
