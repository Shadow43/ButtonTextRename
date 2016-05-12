using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float Speed = 0.5f;
    public Rigidbody PlayerRB;
    public float timer = 30.0f;
    public bool Timer = false;

    void FixedUpdate()
    {
        if (UIController.GameStarted == true)
        {
            // Move the player forwards
            Vector3 newPosition = transform.position + transform.forward * Speed * Time.fixedDeltaTime;
            PlayerRB.MovePosition(newPosition);
        }
    }
    // Run if we hit into BLOCKING collision
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Hit collider volume");

    }
    // Run if we hit into NON-BLOCKING collision
    void OnTriggerEnter(Collider colliderInfo)
    {
        if (UIController.BlockChoice == 0)
        {
            Debug.Log("Hit collider volume");
        }
        if (UIController.BlockChoice == 1)
        {
            //            Debug.Log("Direction Changed");
            if (UIController.DirVar == 1) 
            transform.eulerAngles = new Vector3(transform.position.x, 0, transform.position.y);
            if (UIController.DirVar == 2)
                transform.eulerAngles = new Vector3(transform.position.x, 90, transform.position.y);
            if (UIController.DirVar == 3)
                transform.eulerAngles = new Vector3(transform.position.x, 180, transform.position.y);
            if (UIController.DirVar == 4)
                transform.eulerAngles = new Vector3(transform.position.x, 270, transform.position.y);
            Speed = Speed + 0.2f;
            UIController.ButtonClick = false;
            UIController.BlockChoice = 0;
        }
        if (UIController.BlockChoice == 2)
        {
           if (UIController.SpeedChange)
                {
                Speed = Speed+1.0f;
               }
            else {
                Speed = Speed-0.2f;
            }
            UIController.ButtonClick = false;
            UIController.BlockChoice = 0;
        }
        if (UIController.BlockChoice == 3)
        {
            PlayerRB.transform.position = colliderInfo.transform.position;
            UIController.BlockChoice = 0;
            UIController.ButtonClick = false;
        }
        if (UIController.BlockChoice == 4)
        {
            Debug.Log("Block stops");
            Speed = 0.0f;
            UIController.ButtonClick = false;
            UIController.BlockChoice = 0;
        }
    }
    
}
