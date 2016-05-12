using UnityEngine;
using System.Collections;

public class UI_DirectionButton : MonoBehaviour {
    UnityEngine.UI.Text textDisplay;

    // Use this for initialization
    void Start () {
        textDisplay = GetComponentInChildren<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update () {
	}
    public void DirectionChange()
    {
        if (UIController.DirVar == 0)
              Debug.Log("Keep Button Text the same");
            textDisplay.text = "Change Direction";
        if (UIController.DirVar == 1)
                Debug.Log("Change Button text to north");
//        textDisplay.text = "North Direction";
        if (UIController.DirVar == 2)
            Debug.Log("Change Button text to East");
//          textDisplay.text = "East Direction";
        if (UIController.DirVar == 3)
            Debug.Log("Change Button text to South");
//          textDisplay.text = "South Direction";
        if (UIController.DirVar == 4)
            Debug.Log("Change Button text to West");
//          textDisplay.text = "West Direction";
        Debug.Log("Change Button text");
    }

}
