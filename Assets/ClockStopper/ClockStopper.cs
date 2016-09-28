using UnityEngine;
using System.Collections;

public class ClockStopper : MonoBehaviour {

    public float myTimeBend = 1f;


	void Start ()
    {
	
	}
	

	void Update ()
    {
        
	}

    public void BendTime(float timeBend)
    {
        myTimeBend = timeBend;
    }
}
