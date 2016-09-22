using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController2 : MonoBehaviour {
    private float spacing = 35;
    public Marble currentMarble;
    public Marble middleMarble;
    public Marble targetMarble;
    public bool marbleSelected = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
	}

    void MarblePressed(Marble mar)
    {
        if(marbleSelected == false)
        {
            currentMarble = mar;
            marbleSelected = true;
        }
        else
        {
            targetMarble = mar;
            marbleSelected = false;
        }
    }

    void PlayCheck()
    {

    }
}
