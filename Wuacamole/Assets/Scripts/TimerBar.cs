using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBar : MonoBehaviour
{
    public bool timerIsCharged;
    public GameObject strikingObject;
    void Start()
    {
        timerIsCharged = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsCharged)
        {
            checkForAvailableMolesToStrike();
        }
    }

    public void setTimerToCharged()
    {
        timerIsCharged = true;
    }

    public void setTimerToNotCharged()
    {
        timerIsCharged = false;
    }

    public void checkForAvailableMolesToStrike()
    {
        
            for(int i = 0; i < GameManager.instance.moles.Length; i++)
            {
                if(GameManager.instance.moles[i].GetComponent<Mole>().moleIsStrikable)
                {
                    int reference = GameManager.instance.moles[i].GetComponent<Mole>().uniqueRefForMole;
                    GameManager.instance.hammers[reference].GetComponent<StrikerProperties>().hammerStrike();
                    GetComponent<Animator>().Play("Timer_Filling", -1, 0);
                    break;



            }
            }
        }
    }

