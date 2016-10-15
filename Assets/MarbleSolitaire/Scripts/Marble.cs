using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Marble : MonoBehaviour {

    public enum MarbleState
    {
        CLEAR,
        NONE,
        JELLY
    }
    private Color marbleColor = Color.blue;
    private Color clearColor = Color.white;
    private Color noneThere = Color.grey;

    public MarbleState state = MarbleState.CLEAR;
    public PlayerController2 player;

    // Use this for initialization
    void Start () {
        changeColors();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MarbleClicked()
    {
        player.AddMarble(this.gameObject.GetComponent<Marble>());
    }

    public void changeColors()
    {
        switch (state)
        {
            case MarbleState.CLEAR:
                this.gameObject.GetComponent<Image>().color = clearColor;
                break;

            case MarbleState.JELLY:
                this.gameObject.GetComponent<Image>().color = marbleColor;
                break;

            case MarbleState.NONE:
                this.gameObject.GetComponent<Image>().color = noneThere;
                break;
        }
    }
    
}
