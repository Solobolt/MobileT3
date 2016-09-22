using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float jump = 3.0f;
    public float myGravityScale = 9.8f;

    private Rigidbody2D rb;
    private float startingY;
    private RectTransform myTransform;
	// Use this for initialization
	void Start () {
        myTransform = gameObject.GetComponent<RectTransform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        startingY = myTransform.localPosition.y;
	}
	
	// Update is called once per frame
	void Update () {
	    
       if(Input.GetKeyDown("space"))
       {
            rb.velocity = transform.right * myGravityScale;
            myGravityScale = myGravityScale * (-1);
            rb.gravityScale = myGravityScale;
            rb.AddForce(transform.right * jump * (-myGravityScale));
            
       }

        foreach (Touch touch in Input.touches)
        {

            if(touch.phase == TouchPhase.Began)
            {
                rb.velocity = transform.right * myGravityScale;
                myGravityScale = myGravityScale * (-1);
                rb.gravityScale = myGravityScale;
                rb.AddForce(transform.right * jump * (-myGravityScale));
            }
        }

        Vector3 tempPos = myTransform.localPosition;
        tempPos.y = startingY;
        myTransform.localPosition = tempPos;

    }



}
