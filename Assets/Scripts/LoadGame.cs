using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoadGame : MonoBehaviour {

    public Slider progressBar;
    public GameObject loadingScreen;
    public TextMeshProUGUI progressText;

    public void GameLoader(int sceneIndex) {
        StartCoroutine(LoadAsynchronously(sceneIndex));  // Call the sceneLoad operation in the IEnum
    }

    IEnumerator LoadAsynchronously(int sceneIndex) {

        AsyncOperation sceneLoad = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);

        while (!sceneLoad.isDone) {
            // Since loading only goes up to 0.9 (because of activation) we can clamp the value to get a perfect 0-1.
            float progress = Mathf.Clamp01(sceneLoad.progress / .9f);
            progressBar.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null; // Wait until the next frame to continue
        }

        if (sceneLoad.isDone) { Debug.Log("[TGoT]: Finished loading game (sceneIndex: " + sceneIndex + ")"); }
    }
}
