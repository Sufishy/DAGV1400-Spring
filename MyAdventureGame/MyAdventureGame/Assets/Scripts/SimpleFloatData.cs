using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Single Variables/SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
    public float value;
    public UnityEvent onZeroHealth;

    public void UpdateValue(float amount)
    {
        value += amount;

        if (value <= 0)
        {
            value = 0;
            onZeroHealth.Invoke(); // 💀 THIS TRIGGERS DEATH
        }
    }

    public void SetValue(float amount)
    {
        value = amount;
    }
}