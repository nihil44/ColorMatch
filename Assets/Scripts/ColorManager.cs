using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class ColorManager : MonoBehaviour
{
    public enum ColorName { Red, Blue, Green, Yellow }
    public Image targetColorImage;
    public TextMeshProUGUI scoreText;

    private ColorName currentTargetColorName;
    private int score = 0;

    private Dictionary<ColorName, Color> colorDict = new Dictionary<ColorName, Color>()
    {
    { ColorName.Red, Color.red },
    { ColorName.Blue, Color.blue },
    { ColorName.Green, Color.green },
    { ColorName.Yellow, Color.yellow }
    };

    void Start()
    {
        SetRandomColor();
    }

    void SetRandomColor()
{
    ColorName[] keys = new ColorName[] { ColorName.Red, ColorName.Blue, ColorName.Green, ColorName.Yellow };
    int index = Random.Range(0, keys.Length);
    currentTargetColorName = keys[index];
    targetColorImage.color = colorDict[currentTargetColorName];

    Debug.Log("Yeni hedef renk: " + currentTargetColorName);
}

    public void CheckColor(int colorIndex)
{
    ColorName clickedColor = (ColorName)colorIndex;

    Debug.Log("Tıklanan renk: " + clickedColor);

    if (clickedColor == currentTargetColorName)
    {
        score++;
    }
    else
    {
        score--;
    }

    scoreText.text = "Score: " + score;
    SetRandomColor();
}
}

