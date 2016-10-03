using UnityEngine;
using System.Collections;

public class ColourBlock : MonoBehaviour {

    public enum BlockColour
    {
        BLUE,
        GREEN,
        RED,
        YELLOW
    }

    public BlockColour blockColour;

    private GameCoulorBlock gameController;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameCoulorBlock>();
    }

    public void checkGC()
    {
        if (blockColour == gameController.CurrentColour)
        {
            print("Win");
        }
        else
        {
            print("Fail");
        }
    }
	
}
