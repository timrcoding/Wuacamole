﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public GameObject[] moles;
    //SETS INTERVAL FOR MOLE SPAWN IN GAME;
    public int tickInterval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Clock());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Clock()
    {
        spawnMole();
        yield return new WaitForSeconds(tickInterval);
        StartCoroutine(Clock());
    }

    public void spawnMole()
    {
        Debug.Log("MOLE!");
        //CHOOSE RANDOM MOLE OF THOSE AVAILABLE
        int randomChoice = Random.Range(0, moles.Length);
        if (moles[randomChoice].GetComponent<Mole>().moleIsAvailable)
        {
            moles[randomChoice].GetComponent<Mole>().moveMole();
        }
        else
        {
            spawnMole();
        }

    }
}
