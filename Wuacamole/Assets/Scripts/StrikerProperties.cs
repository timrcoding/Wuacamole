using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikerProperties : MonoBehaviour
{
    public int hammerRef;
    public GameObject hammer;

    private void Start()
    {
       disableStriker();
    }


    public void hammerStrike()
    {
        hammer.SetActive(true);
        GetComponent<Animator>().SetTrigger("Swing");
    }

    public void animateMoleStrike()
    {
        GameManager.instance.moles[hammerRef].GetComponent<Animator>().SetTrigger("Mole_Hit");
        Scoring.instance.incrementScore();
    }

    public void disableStriker()
    {
       hammer.SetActive(false);
    }

    public void setToIdle()
    {
        GetComponent<Animator>().SetTrigger("Idle");
    }

}
