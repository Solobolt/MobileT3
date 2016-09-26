using UnityEngine;
using System.Collections;

public class OuterBarriers : MonoBehaviour
{

    public enum MoveState
    {
        HORIZONTAL,
        VERTICAL,
        NONE
    }

    private float xLimit = 300.0f;
    private float yLimit = 300.0f;

    private float startY;
    private float startX;

    private float myLimitX;
    private float myLimitY;

    private Vector2 finalPos;
    private RectTransform rect;

    private Rigidbody2D rb;

    public MoveState state = MoveState.NONE;
    public bool is3Block = false;

    // Use this for initialization
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        rect = this.gameObject.GetComponent<RectTransform>();
        myLimitX = xLimit - (rect.sizeDelta.x * 0.5f);
        myLimitY = yLimit - (rect.sizeDelta.y * 0.5f);

        startX = rect.localPosition.x;
        startY = rect.localPosition.y;
    }

    public void OnDrag()
    {
        //rb.velocity = (Input.mousePosition - transform.position) * 10;
        transform.position = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        finalPos = rect.localPosition;

        switch (state)
        {
            case MoveState.HORIZONTAL:

                if (finalPos.x >= myLimitX)
                    finalPos.x = myLimitX;

                if (finalPos.x <= -myLimitX)
                    finalPos.x = -myLimitX;

                if (Input.GetAxis("Fire1") == 0)
                {
                    if (is3Block)
                    {
                        finalPos.x = ((Mathf.RoundToInt((finalPos.x - 50) * 0.01f)) * 100) + 50;
                    }
                    else
                    {
                        finalPos.x = (Mathf.RoundToInt(finalPos.x * 0.01f)) * 100;
                    }
                }
                finalPos.y = startY;
                break;

            case MoveState.VERTICAL:

                if (finalPos.y >= myLimitY)
                    finalPos.y = myLimitY;

                if (finalPos.y <= -myLimitY)
                    finalPos.y = -myLimitY;
                if (Input.GetAxis("Fire1") == 0)
                {
                    if (is3Block)
                    {
                        finalPos.y = ((Mathf.RoundToInt((finalPos.y - 50) * 0.01f)) * 100) + 50;
                    }
                    else
                    {
                        finalPos.y = (Mathf.RoundToInt(finalPos.y * 0.01f)) * 100;
                    }
                }

                finalPos.x = startX;
                break;

            default:
            case MoveState.NONE:
                break;
        }

        rect.localPosition = finalPos;
    }
}
