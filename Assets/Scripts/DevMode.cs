using UnityEngine;
using UnityEngine.InputSystem;

public class DevMode : MonoBehaviour
{
    private static bool devModeEnabled = false;

    // TODO: Attach to something
    void Start()
    {
        // If we're editing the game, automatically enable devMode
        switch (Application.platform) { case RuntimePlatform.WindowsEditor: case RuntimePlatform.OSXEditor: case RuntimePlatform.LinuxEditor: 
                devModeEnabled = true; Debug.Log($"[TGoT]: Editor detected ({Application.platform}), DevMode auto-enabled."); break; }
    
    }

    // Update is called once per frame
    void Update()
    {
        // We want to use GetKeyDown here, which happens once the combo is hit, rather than GetKey, which continuously triggers while the key combo is held.
        if (Keyboard.current.leftCtrlKey.isPressed && Keyboard.current.leftAltKey.isPressed && Keyboard.current.leftShiftKey.isPressed && Keyboard.current.dKey.wasPressedThisFrame)
        {
            // This key combination will act as a toggle, rather than a one-time enable, so we'll use !devModeEnabled.
            devModeEnabled = !devModeEnabled;
            
            // Indication of devMode enabled or disabled (TODO: add GUI indication)
            switch (devModeEnabled) { case true:    Debug.Log("[TGoT]: DevMode enabled. "); break;  case false:     Debug.Log("[TGoT]: DevMode disabled."); break; }
        }
    
    } 

    public static bool IsEnabled() {return devModeEnabled; }

}
