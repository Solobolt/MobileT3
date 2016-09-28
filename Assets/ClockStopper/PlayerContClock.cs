using UnityEngine;
using System.Collections;

public class PlayerContClock : MonoBehaviour {

    public ClockStopper clockStopper;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        foreach (Touch touch in Input.touches)
        {

            if (touch.phase == TouchPhase.Began)
            {
                clockStopper.BendTime(0.2f);
            }

            if (touch.phase == TouchPhase.Ended)
            {
                clockStopper.BendTime(1f);
            }

            if (touch.phase == TouchPhase.Canceled)
            {
                clockStopper.BendTime(1f);
            }
        }

        if (Input.GetKey("space"))
        {
            clockStopper.BendTime(0.2f);
        }
        else
        {
            clockStopper.BendTime(1f);
        }
	}
}
