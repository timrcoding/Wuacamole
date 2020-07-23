using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public bool moleIsAvailable;
    public int uniqueRefForMole;
    [HideInInspector]
    public bool moleIsStrikable;
    // Start is called before the first frame update
    void Start()
    {
        moleIsAvailable = true;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveMole()
    {
        if (moleIsAvailable)
        {
            this.GetComponent<Animator>().SetTrigger("Move_Mole");
        }
    }

    public void moleAvailable()
    {
        moleIsAvailable = true;
    }

    public void moleNotAvailable()
    {
        moleIsAvailable = false;
    }

    public void moleCaught()
    {
        if (moleIsAvailable)
        {
            Debug.Log("Caught");
            this.GetComponent<Animator>().SetTrigger("Mole_Hit");
            Scoring.instance.incrementScore();
        }
    }

    public void moleIdle()
    {
        this.GetComponent<Animator>().SetTrigger("Mole_Idle");
    }

    public void setMoleStrikability()
    {
        StartCoroutine(moleStrikableForOneFrame());
    }

    public IEnumerator moleStrikableForOneFrame()
    {
        moleIsStrikable = true;
        Debug.Log("Mole " + uniqueRefForMole + " is strikable");
        yield return new WaitForSeconds(Time.deltaTime);
        moleIsStrikable = false;
    }
}
