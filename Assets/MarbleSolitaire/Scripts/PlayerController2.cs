using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController2 : MonoBehaviour {

    public Marble[] allMarbles;

    public Marble currentMarble;
    private int curNum;
    public Marble middleMarble;
    private int midNum;
    public Marble targetMarble;
    private int tarNum;
    public bool marbleSelected = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
	}

    public void AddMarble(Marble mar)
    {
        if(marbleSelected == false)
        {
            if(mar.state == Marble.MarbleState.MARBLE)
            {
                currentMarble = mar;
                targetMarble = null;
                marbleSelected = true;
                int.TryParse(mar.gameObject.name, out curNum);
                print("current: " + curNum);
            }
            
        }
        else
        {
            targetMarble = mar;
            marbleSelected = false;
            int.TryParse(mar.gameObject.name, out tarNum);
            print("current: " + curNum);
            print("target: " + tarNum);

            PlayCheck();
        }

        
    }


    void CheckMiddle()
    {
        if (curNum % 5 != 4 && curNum % 5 != 3)
        {
            if (tarNum == curNum + 2)
            {
                midNum = (curNum + 1);
                if (allMarbles[midNum].state == Marble.MarbleState.MARBLE)
                {
                    SetMarbles();
                }
            }
        }

        if (curNum % 5 != 1 && curNum % 5 != 0)
        {
            if (tarNum == curNum - 2)
            {
                midNum = (curNum - 1);
                if (allMarbles[midNum].state == Marble.MarbleState.MARBLE)
                {
                    SetMarbles();
                }
            }
        }
        

        if (tarNum == curNum + 10)
        {
            midNum = (curNum + 5);
            if (allMarbles[midNum].state == Marble.MarbleState.MARBLE)
            {
                SetMarbles();
            }
        }

        if (tarNum == curNum - 10)
        {
            midNum = (curNum - 5);
            if (allMarbles[midNum].state == Marble.MarbleState.MARBLE)
            {
                SetMarbles();
            }
        }
    }

    void SetMarbles()
    {
        allMarbles[midNum].state = Marble.MarbleState.CLEAR;
        allMarbles[midNum].changeColors();

        allMarbles[curNum].state = Marble.MarbleState.CLEAR;
        allMarbles[curNum].changeColors();

        allMarbles[tarNum].state = Marble.MarbleState.MARBLE;
        allMarbles[tarNum].changeColors();
    }

    void PlayCheck()
    {
        if (allMarbles[curNum].state == Marble.MarbleState.MARBLE && allMarbles[tarNum].state == Marble.MarbleState.CLEAR)
        {
            CheckMiddle();
        }

    }
}
