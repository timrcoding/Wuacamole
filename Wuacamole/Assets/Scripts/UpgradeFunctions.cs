using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFunctions : MonoBehaviour
{
    public static UpgradeFunctions instance;
    public GameObject[] UpgradePositions;

    [SerializeField]
    private GameObject[] upgrades;

    private void Awake()
    {
        instance = this;
    }

    public void timesTwo()
    {
        
        Scoring.instance.scoreMultiplier = 2;
    }

    public void checkForUpgradeAvailability()
    {
        foreach(GameObject g in upgrades)
        {
            if(Scoring.instance.scorePoints >= g.GetComponent<UpgradeStatus>().activationScore)
            {
                g.GetComponent<UpgradeStatus>().activateButton();
            }
        }
    }
}
