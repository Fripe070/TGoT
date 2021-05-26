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

        if (transform.position.x < -8f)
        {

            var transform1 = transform;
            var position = transform1.position;
            position = new Vector3(-7.9f, position.y, position.z);
            transform1.position = position;
        }
        else if (transform.position.x > 28f)
        {
            var transform1 = transform;
            var position = transform1.position;
            position = new Vector3(27.9f, position.y, position.z);
            transform1.position = position;
        }

    }
}
