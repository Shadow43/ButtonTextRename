using UnityEngine;
using System.Collections;

public class UI_TimeRemaining : MonoBehaviour {
    UnityEngine.UI.Text textDisplay;

    // Use this for initialization
    void Start () {
        textDisplay = GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update () {

	}
    public void timeleft(float timeRemaining)
    {
        textDisplay.text = "Time Remaining: " + timeRemaining.ToString("0.0");
    }
}
