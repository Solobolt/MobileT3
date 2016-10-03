using UnityEngine;
using System.Collections;

public class MazeMovement : MonoBehaviour
{
    private float speed = 80f;
    public Rigidbody2D rb;
    Vector2 tempVel;
    bool moveUp;
    bool moveDown;
    bool moveLeft;
    bool moveRight;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(0,0);

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

        if(moveUp == true)
        {
            tempVel.y = -speed;
        }

        if(moveDown == true)
        {
            tempVel.y = speed;
        }

        if (moveLeft == true)
        {
            tempVel.x = speed;
        }

        if (moveRight == true)
        {
            tempVel.x = -speed;
        }

        rb.velocity = tempVel;
    }

    public void MoveUp()
    {
        StopMoving();
        moveUp = true;
    }

    public void MoveDown()
    {
        StopMoving();
        moveDown = true;
    }

    public void MoveLeft()
    {
        StopMoving();
        moveLeft = true;
    }

    public void MoveRight()
    {
        StopMoving();
        moveRight = true;
    }

    public void StopMoving()
    {
        moveUp = false;
        moveDown = false;
        moveLeft = false;
        moveRight = false;

        tempVel = new Vector2(0, 0);
    }

}
