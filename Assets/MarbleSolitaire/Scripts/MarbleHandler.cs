using UnityEngine;
using System.Collections;

public class MarbleHandler : MonoBehaviour {

    public Marble[,] marbles = new Marble[10,10];
	// Use this for initialization
	void Start () {
        marbles[2, 2].state = Marble.MarbleState.JELLY;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
