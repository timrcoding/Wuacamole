using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static Scoring instance;
    [SerializeField]
    private TextMeshProUGUI scoreBoard;
    public int scorePoints;
    public int scoreMultiplier = 1;

    private void Awake()
    {
        instance = this;
    }

    public void incrementScore()
    {
        scorePoints += 1 * scoreMultiplier;
        setPointsOnBoard();
        UpgradeFunctions.instance.checkForUpgradeAvailability();
    }

    public void setPointsOnBoard()
    {
        scoreBoard.text = "Points: " + scorePoints;
    }
    
}
