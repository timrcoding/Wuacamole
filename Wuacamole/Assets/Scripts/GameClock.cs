using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClock : MonoBehaviour
{
    public static GameClock instance;
    public int tickInterval;
    void Start()
    {
        instance = this;
    }

    public IEnumerator Clock()
    {
        yield return new WaitForSeconds(tickInterval);
        yield return true;
    }
}
