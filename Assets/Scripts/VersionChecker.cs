using Newtonsoft.Json; using System.Net;  // For acquiring the update JSON
using TMPro;  // For modifying TMP text
// Unity Imports:
using UnityEngine;
using UnityEngine.Events;   using UnityEngine.EventSystems;

public class VersionChecker : MonoBehaviour, IPointerClickHandler
{

    public UnityEvent onClick;    // This allows us to add items to the onClick() list in Unity (Inspector tab)
    public TMP_Text gameVersionText;    // The TMP text that displays the game version
    public GameObject notLatestVersionIcon;

    private string latestGameVersion;
    private const string UpdateJsonURL = "https://raw.githubusercontent.com/TechnoShip123/TGoT/master/update.json";

    public static bool hasInternetConnection;


    public void Start()
    {
        gameVersionText.text = Application.version;    // What the game version text displays

        GetLatestVersion();  // Get the latest game version from the update JSON.

        // Check if we're on the latest game version, and give a visual indicator if not.
        if (!hasInternetConnection) { gameVersionText.color = Color.yellow; }
        if (!OnLatestVersion())
        {
            gameVersionText.color = Color.red; notLatestVersionIcon.SetActive(true);
        }
        else { Debug.Log("User on latest version."); }

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // IDEA: If DevMode is enabled, check for preview versions.

        onClick.Invoke();   // Invoke the onClick event (will trigger list items in the Inspector tab)

        // onClick.AddListener(delegate () { OpenReleasePage(); });  // This didn't work for the first 1-2 clicks so I've added the method to the onClick() list.
    }

    public void OpenReleasePage()
    { Application.OpenURL("https://github.com/TechnoShip123/TGoT/releases/latest/"); }

    /// <summary> This method will pull the raw update JSON from the link specified in the UpdateJsonURL var. </summary>
    private void GetLatestVersion()
    {
        // Local method vars
        string webUpdateJSON;

        // Check if an internet connnection is available otherwise we may hit an error.
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            hasInternetConnection = true;

            // Download the raw update JSON from the url provided (UpdateJsonURL var)
            using (WebClient wc = new WebClient()) { webUpdateJSON = wc.DownloadString(UpdateJsonURL); }

            // Convert/Deserialize the update JSON and store it in a dynamic var
            dynamic updateJSON = JsonConvert.DeserializeObject(webUpdateJSON);

            // Assign the key values to variables:
            latestGameVersion = updateJSON.version;

            Debug.Log("[TGoT]: Latest game version pulled: " + latestGameVersion);
        }

        // If we don't have an internet connection available.
        else
        {
            hasInternetConnection = false;
            Debug.LogWarning("[TGoT]: Internet connection failed, unable to verify application version.");
        }
    }

    public bool OnLatestVersion()
    {

        // If the user's game version matches the latest game version:
        if (Application.version == latestGameVersion) { return true;  }
        // If we aren't able to check the latest version (no internet connection) assume it is the latest version:
        else if (hasInternetConnection == false) { return true;  }
        // If we can see the latest version (internet available) and it does not match the game version:
        else { Debug.LogWarning($"[TGoT]: User not on latest version! (Playing on: {Application.version} | Latest available: {latestGameVersion})"); return false; }

    }


}
