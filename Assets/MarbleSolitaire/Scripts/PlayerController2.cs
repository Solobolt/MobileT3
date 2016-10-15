using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController2 : MonoBehaviour
{

    public Text gameOverText;

    public Marble[] allMarbles;

    public Marble currentMarble;
    private int curNum;
    public Marble middleMarble;
    private int midNum;
    public Marble targetMarble;
    private int tarNum;
    public bool marbleSelected = false;
    
    

    // Use this for initialization
    void Start()
    {
        CheckAvailableMoves();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMarble(Marble mar)
    {
        if (marbleSelected == false)
        {
            if (mar.state == Marble.MarbleState.JELLY)
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
        if (curNum % 9 != 8 && curNum % 9 != 9)
        {
            if (tarNum == curNum + 2)
            {
                midNum = (curNum + 1);
                if (allMarbles[midNum].state == Marble.MarbleState.JELLY)
                {
                    SetMarbles();
                }
            }
        }

        if (curNum % 9 != 1 && curNum % 9 != 2)
        {
            if (tarNum == curNum - 2)
            {
                midNum = (curNum - 1);
                if (allMarbles[midNum].state == Marble.MarbleState.JELLY)
                {
                    SetMarbles();
                }
            }
        }


        if (tarNum == curNum + 18)
        {
            midNum = (curNum + 9);
            if (allMarbles[midNum].state == Marble.MarbleState.JELLY)
            {
                SetMarbles();
            }
        }

        if (tarNum == curNum - 18)
        {
            midNum = (curNum - 9);
            if (allMarbles[midNum].state == Marble.MarbleState.JELLY)
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

        allMarbles[tarNum].state = Marble.MarbleState.JELLY;
        allMarbles[tarNum].changeColors();

        CheckAvailableMoves();
    }

    void PlayCheck()
    {
        if (allMarbles[curNum].state == Marble.MarbleState.JELLY && allMarbles[tarNum].state == Marble.MarbleState.CLEAR)
        {
            CheckMiddle();
        }

    }

    void CheckAvailableMoves()
    {
        bool thereIsAMove = false;
        int marbleCounter = 0;
        foreach (Marble marbleC in allMarbles)
        {
            if (marbleC.state == Marble.MarbleState.JELLY)
            {
                //if they can move Right there is move == true
                if((marbleCounter+1) % 9 != 8 && (marbleCounter + 1) % 9 != 0)
                {
                    if (marbleCounter + 2 < allMarbles.Length)
                    {
                        if (allMarbles[marbleCounter + 1].state == Marble.MarbleState.JELLY && allMarbles[marbleCounter + 2].state == Marble.MarbleState.CLEAR)
                        {
                            thereIsAMove = true;
                        }
                    }
                }
                //if they can move Left there is move == true
                if((marbleCounter + 1) % 9 != 1 && (marbleCounter + 1) % 9 != 2)
                {
                    if (marbleCounter - 2 > 0)
                    {
                        if (allMarbles[marbleCounter - 1].state == Marble.MarbleState.JELLY && allMarbles[marbleCounter - 2].state == Marble.MarbleState.CLEAR)
                        {
                            thereIsAMove = true;
                        }
                    }
                }

                //if they can move up there is move == true
                if (marbleCounter + 18 < allMarbles.Length)
                {
                    if (allMarbles[marbleCounter + 9].state == Marble.MarbleState.JELLY && allMarbles[marbleCounter + 18].state == Marble.MarbleState.CLEAR)
                    {
                        thereIsAMove = true;
                    }
                }

                //if they can move down there is move == true
                if(marbleCounter - 18 > 0)
                {
                    if (allMarbles[marbleCounter - 9].state == Marble.MarbleState.JELLY && allMarbles[marbleCounter - 18].state == Marble.MarbleState.CLEAR)
                    {
                        thereIsAMove = true;
                    }
                }
            }
            marbleCounter++;
        }

        if (thereIsAMove == false)
        {
            print("GAMEOVER");
            gameOverText.text = "GAME OVER";
        }
    }
}
