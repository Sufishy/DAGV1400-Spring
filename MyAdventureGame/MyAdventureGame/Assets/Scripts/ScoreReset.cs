using UnityEngine;

public class ScriptableResetManager : MonoBehaviour
{
    public SimpleFloatData[] floatDataToReset;
    public float[] defaultValues;

    void Awake()
    {
        for (int i = 0; i < floatDataToReset.Length; i++)
        {
            floatDataToReset[i].SetValue(defaultValues[i]);
        }
    }
}