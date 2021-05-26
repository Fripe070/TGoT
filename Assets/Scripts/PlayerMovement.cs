// ReSharper disable RedundantUsingDirective
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Camera Switcher
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode cameraSwitchKey = KeyCode.G;

    // Local Multiplayer
    // public string inputID;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Start has been called.");
    }

    // Private variables for the driving/turning speeds.
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    void Update()
    {
        // Set our axis
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moving the vehicle forward, and moving it left/right
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * forwardInput));
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        if(Input.GetKeyDown(cameraSwitchKey))  // If the user is pressing the camera switcher key
        { mainCamera.enabled = !mainCamera.enabled; hoodCamera.enabled = !hoodCamera.enabled; }

    }
}
