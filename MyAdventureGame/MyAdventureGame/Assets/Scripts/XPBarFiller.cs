using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPBarFiller : MonoBehaviour
{
    public SimpleFloatData xpData; // Your XP data brain
    public SimpleImageBehaviour imageBehaviour; // Reference to the SimpleImageBehaviour
    public float maxValue = 100f; // Max XP for full bar
    public float fillSpeed = 2f; // How fast it fills

    private float targetValue;

    void Update()
    {
        targetValue = xpData.value / maxValue; // Calculate target fill amount (0-1 range)
        xpData.value = Mathf.Lerp(xpData.value, targetValue * maxValue, Time.deltaTime * fillSpeed); // Smooth XP value
        imageBehaviour.UpdateWithFloatData(); // Force update the bar every frame
    }
}