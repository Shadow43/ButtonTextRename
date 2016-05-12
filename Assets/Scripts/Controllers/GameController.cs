using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public static GameController Instance;
//    public static float timer = 30.0f;
//    public float Ballspeed = 0;
    public int PlacedBlocks = 0;

    // Use this for initialization
    void Awake()
    {
        // Make the Instance variable refer to us
        Instance = this;
    }

    void Start () {

    }

    // Update is called once per frame
    void Update () {
	
	}
}
