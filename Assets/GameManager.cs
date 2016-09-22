using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject[] levelParts;
    private int currentObject = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   
        //spawn object 0 just above the screen

	}

    void SpawnNext()
    {

        currentObject++;
        //instationate currentObject;
    }
}
