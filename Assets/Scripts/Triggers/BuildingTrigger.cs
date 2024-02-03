using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingTrigger : MonoBehaviour
{
    public int sceneToLoad;
    public string exitName;

    public void TriggerNewScene()
    {
        Debug.Log("Trigger Scene " + sceneToLoad.ToString());
        PlayerPrefs.SetString("LastExitName", exitName);
        SceneManager.LoadScene(sceneToLoad);
    }
}
