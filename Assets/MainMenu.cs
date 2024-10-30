using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Function for the Play button
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Replace "GameScene" with the name of your game scene
    }

    // Function for the Multiplayer button
    public void MultiplayerGame()
    {
        SceneManager.LoadScene("MultiplayerScene"); // Replace "MultiplayerScene" with the name of your multiplayer scene
    }

    // Function for the Settings button
    public void OpenSettings()
    {
        // This function can load a settings menu scene or enable a settings UI panel
        SceneManager.LoadScene("SettingsScene"); // Replace "SettingsScene" with the name of your settings scene
    }

    // Function for the Exit button
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting"); // Only visible in the editor
    }
}
