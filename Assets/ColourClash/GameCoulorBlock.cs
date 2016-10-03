using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameCoulorBlock : MonoBehaviour {

    public ColourBlock.BlockColour CurrentColour = ColourBlock.BlockColour.BLUE;

    private int colourNumb = 0;

    public Text text;

    private float timer;
    private float colourSwapTime = 3.0f;

	// Use this for initialization
	void Start () {
        timer = colourSwapTime;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            colourNumb++;
            switch (colourNumb)
            {
                case 0:
                    text.text = "GREEN";
                    CurrentColour = ColourBlock.BlockColour.GREEN;
                    text.color = Color.yellow;
                    break;
                case 1:
                    text.text = "RED";
                    CurrentColour = ColourBlock.BlockColour.RED;
                    text.color = Color.cyan;
                    break;
                case 2:
                    text.text = "YELLOW";
                    CurrentColour = ColourBlock.BlockColour.YELLOW;
                    text.color = Color.cyan;
                    break;
                case 3:
                    text.text = "BLUE";
                    CurrentColour = ColourBlock.BlockColour.BLUE;
                    text.color = Color.green;
                    break;
                default:
                    text.text = "DEMO";
                    CurrentColour = ColourBlock.BlockColour.BLUE;
                    text.color = Color.black;
                    break;
            }

            
            timer = colourSwapTime;
        }
	}
}
