using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPContainerScript : MonoBehaviour
{
    public SimpleFloatData xpData;

    public void AddXP(float amount)
    {
        xpData.UpdateValue(amount);
    }
}