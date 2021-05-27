// ReSharper disable RedundantUsingDirective

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    // Camera Switcher
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode cameraSwitchKey = KeyCode.G;
    
    // Audio
    public AudioSource coneSound;

    // Start is called before the first frame update
    void Start()
    {
        coneSound = GetComponent<AudioSource>();
    }

    // Private variables for the driving/turning speeds.
    private float speed = 20.0f;
    private float turnSpeed = 55.0f;
    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    [SuppressMessage("ReSharper", "Unity.InefficientPropertyAccess")]
    void Update()
    {
        // Set our axis
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moving the vehicle forward, and moving it left/right
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * forwardInput));
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        // If the user is pressing the camera switcher key
        if(Input.GetKeyDown(cameraSwitchKey)) 
        { mainCamera.enabled = !mainCamera.enabled; hoodCamera.enabled = !hoodCamera.enabled; }

        // Invisible boundaries for the X axis (left/right)
        // var current_pos = transform.position;
        // if (transform.position.x < -8f) {transform.position = new Vector3(-7.9f, current_pos.y, current_pos.z); }
        // else if (transform.position.x > 28f) {transform.position = new Vector3(27.9f, current_pos.y, current_pos.z); }
        
        //  A safety net at the bottom in case you fall
        if (transform.position.y < -40)
        {
            transform.position = new Vector3(0f, 0f, 75f);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        // ReSharper disable once CompareOfFloatsByEqualityOperator
        // Check the car's rotation, if it is upside down (y=-1) then flip the car back up (y=1):
        if (transform.up.y == -1f) { transform.rotation = Quaternion.Euler(transform.up.x,1,transform.up.z); }

    }
    // Event function for when we collide with an object:
    void OnCollisionEnter(Collision collision) {
        // If we collide with a Traffic Cone [Obstacle], play a traffic cone sound.
        if (collision.gameObject.CompareTag("TrafficConeObstacle")) {
            coneSound.Play();
        }
    }
}
