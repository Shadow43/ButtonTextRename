using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{
    // setup function and variable names
    public EventSystem LevelEventSystem;
    public static int DirVar = 0;
    public static bool ButtonClick = false;
    public static bool SpeedChange = false;
    public static bool GameStarted = false;
    public static int BlockChoice = 0;
    public float timeRemaining = 300f;
    public UI_BallSpeed SpeedDisplay;
    public static UIController Instance;
    public PlayerController playercontroller;
    public UI_TimeRemaining TimeRemainingDisplay;
    public UI_PlacedBlocks BlocksDisplay;
    public GameController gamecontroller;
    public UI_DirectionButton DirectionDisplay;

    // Use this for initialization
    void Awake()
    {
        Instance = this;
        }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameStarted == true)
            timeRemaining -= Time.deltaTime;

        SpeedofBall(playercontroller.Speed);
        timeleft(timeRemaining);
        NumberOfBlocks(gamecontroller.PlacedBlocks);

        // Has the user clicked on the primary mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // Is the current mouse location over the UI
            if (LevelEventSystem.IsPointerOverGameObject())
            {
            }
            else
            {
                // Set up the ray based on the mouse location
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                // Perform a raycast to deterime what has been hit
                RaycastHit hitResults;
                if (Physics.Raycast(ray, out hitResults))
                {
                    // Retrieve the game object that was hit
                    GameObject hitObject = hitResults.collider.gameObject;

                    // Attempts to retieve the platform 
                    GridBlock gridblock = hitObject.GetComponent<GridBlock>();
                    if (gridblock != null)
                    {
                        gridblock.ReactToMouseClick();
                    }
                    else
                    {
                        // Attempt to find the platform in the parent
                       gridblock = hitObject.GetComponentInParent<GridBlock>();
                        if (gridblock != null)
                        {
                            gridblock.ReactToMouseClick();
                        }
                    }
                }
            }
        }
        if (timeRemaining < 0.00f)
        {
            Application.LoadLevel(2);
        }

    }
    // Main Menu Game Buttons
    public void PlayGame()
    {
        Application.LoadLevel(1);
    }
    public void ViewCredits()
    {
        Application.LoadLevel(3);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
// Level Buttons
    public void Restart()
    {
        DirVar = 0;
        GameStarted = false;
        ButtonClick = false;
        Application.LoadLevel(Application.loadedLevelName);
    }
    public void Run()
    {
        GameStarted = true;
    }
    public void Direction()
    {
        if (ButtonClick == false)
            ButtonClick = true;
        BlockChoice = 1;
        DirVar = DirVar + 1;
        if (DirVar > 4) DirVar = 1;
        if (DirVar == 1);
        if (DirVar == 2);
        if (DirVar == 3);
        if (DirVar == 4);
    }

    public void BallSpeed()
    {
        if (ButtonClick == false)
            ButtonClick = true;
        BlockChoice = 2;
        SpeedChange = !SpeedChange;
    }
    public void Teleporter()
    {
        BlockChoice = 3;
        ButtonClick = true;
    }
    public void StopPER()
    {
        BlockChoice = 4;
        ButtonClick = true;
    }
    public void SpeedofBall(float ballspeed)
    {
        SpeedDisplay.SpeedofBall(ballspeed);
    }
    public void timeleft(float timeRemaining)
    {
        TimeRemainingDisplay.timeleft(timeRemaining);
    }
    public void NumberOfBlocks(int BlocksPlaced)
    {
        BlocksDisplay.NumberOfBlocks(BlocksPlaced);
    }
    public void DirectionChange()
    {
        DirectionDisplay.DirectionChange();
    }

}
