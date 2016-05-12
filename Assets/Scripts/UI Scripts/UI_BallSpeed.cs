using UnityEngine;
using System.Collections;

public class UI_BallSpeed : MonoBehaviour {
    UnityEngine.UI.Text textDisplay;

    // Use this for initialization
    void Start () {
        textDisplay = GetComponent<UnityEngine.UI.Text>();

    }
public void SpeedofBall(float ballspeed)
    {
        textDisplay.text = "Ball Speed: " + ballspeed.ToString();
    }

}
