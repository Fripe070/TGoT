using UnityEngine;
// using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // TODO: Add application version/onclick to latest release page?
    public void QuitGame() {
        // The Application.Quit(); method closes the Unity Editor, so I have this here for debugging purposes.
        switch (Application.platform)
        { case RuntimePlatform.WindowsEditor: case RuntimePlatform.OSXEditor: case RuntimePlatform.LinuxEditor:
                Debug.Log("[TGoT]: QuitGame() called from " + GetType().Name + " object. Editor/Debug Mode detected, will not exit."); break;

            // If we aren't in editor/debugging mode, actually quit the game:
            default:    Application.Quit(); break;
        }
    }

}
