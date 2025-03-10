using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SimpleTextMeshProBehaviour : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;

    public float fontSizeIncrease = 50f; // Amount to increase the font size
    public int maxFontSize = 200;        // Maximum font size
    private int lastScore = 0;           // Store the last score value

    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        UpdateWithIntData();
    }

    public void UpdateWithIntData()
    {
        textObj.text = dataObj.value.ToString(CultureInfo.InvariantCulture);

        // Only increase font size if the score has increased
        if (dataObj.value > lastScore)
        {
            // Increase font size, but cap it at maxFontSize
            if (textObj.fontSize < maxFontSize)
            {
                textObj.fontSize += fontSizeIncrease;
            }

            // Update lastScore to the current score
            lastScore = dataObj.value;
        }
    }
}