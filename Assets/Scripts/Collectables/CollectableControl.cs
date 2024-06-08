using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    public string CoinCount;
    public string CoinEndCount; // Add a variable to store the end screen object name

    public TextMeshProUGUI coinCountDisplay;
    public TextMeshProUGUI coinEndDisplay; // Add the TextMeshProUGUI for the end screen

    void Start()
    {
        coinCountDisplay = GameObject.Find(CoinCount)?.GetComponent<TextMeshProUGUI>();
        coinEndDisplay = GameObject.Find(CoinEndCount)?.GetComponent<TextMeshProUGUI>(); // Initialize coinEndDisplay
    }

    void Update()
    {
        if (coinCountDisplay != null)
        {
            coinCountDisplay.text = "" + coinCount;
        }

        if (coinEndDisplay != null)
        {
            coinEndDisplay.text = "" + coinCount; // Update the end screen display
        }
    }
}




