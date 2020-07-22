using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleCollider : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<Mole>().moleCaught();
    }
}
