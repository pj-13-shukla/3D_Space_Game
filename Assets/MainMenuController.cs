using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // This function will be called when the Settings button is clicked
    public void LoadSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene"); // Make sure the name matches your settings scene
    }
}
