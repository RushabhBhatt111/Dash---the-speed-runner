using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelDistance : MonoBehaviour
{
    public string DisDisplayObjectName;  // Name of the TextMeshProUGUI object
    public string DisEndDisplayObjectName;  // Name of the end screen TextMeshProUGUI object
    public float disRun;
    public bool addingDis = false;
    public float disDelay = 0.35f;
    public bool isRunning = true;  // Flag to indicate if the player is running

    public TextMeshProUGUI disDisplay;  // Public field for the main distance display
    public TextMeshProUGUI disEndDisplay;  // Public field for the end screen distance display

    void Start()
    {
        disDisplay = GameObject.Find(DisDisplayObjectName)?.GetComponent<TextMeshProUGUI>();
        disEndDisplay = GameObject.Find(DisEndDisplayObjectName)?.GetComponent<TextMeshProUGUI>();
        Debug.Log("Start method executed");
    }

    void Update()
    {
        if (!addingDis && isRunning)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        while (isRunning)
        {
            disRun += 1;
            if (disDisplay != null)
            {
                disDisplay.text = disRun.ToString();
                Debug.Log("disDisplay updated: " + disRun);
            }
            yield return new WaitForSeconds(disDelay);
        }
        addingDis = false;
        UpdateEndDisplay();  // Ensure end display is updated once running stops
    }

    public void StopRunning()
    {
        isRunning = false;
        UpdateEndDisplay();
    }

    private void UpdateEndDisplay()
    {
        if (disEndDisplay != null)
        {
            disEndDisplay.text = disRun.ToString();
            Debug.Log("disEndDisplay updated: " + disRun);
        }
    }
}
