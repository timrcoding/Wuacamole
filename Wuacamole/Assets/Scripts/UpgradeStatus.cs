using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeStatus : MonoBehaviour
{
    public int activationScore;
    public bool activated;
    public Color colour;

    private void Start()
    {
        GetComponent<Image>().color = Color.grey;
    }

    public void activateButton()
    {

        GetComponent<Image>().color =  colour;
        activated = true;
    }
}
