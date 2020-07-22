using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public bool moleIsAvailable;
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
}
