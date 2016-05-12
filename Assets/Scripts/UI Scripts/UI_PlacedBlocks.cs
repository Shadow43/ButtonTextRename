using UnityEngine;
using System.Collections;

public class UI_PlacedBlocks : MonoBehaviour {
    UnityEngine.UI.Text textDisplay;

    // Use this for initialization
    void Start () {
        textDisplay = GetComponent<UnityEngine.UI.Text>();
    }

public void NumberOfBlocks(int BlocksPlaced)
    {
        textDisplay.text = "Blocks Placed: " + BlocksPlaced.ToString();
    }

}
