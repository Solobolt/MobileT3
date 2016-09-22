using UnityEngine;
using System.Collections;


public class Marble : MonoBehaviour {

    public enum MarbleState
    {
        CLEAR,
        NONE,
        MARBLE
    }

    public MarbleState state = MarbleState.CLEAR;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
