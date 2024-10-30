using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    // Sensitivity for touch input (default value can be adjusted)
    private float touchSensitivityMultiplier = 1.0f;

    // This method will be called by the volume slider
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

    // This method will be called by the graphics quality dropdown
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    // This method will be called when changing screen mode (fullscreen toggle)
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    // This method will be called by the back button to return to the main menu
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // This method will be called by the sensitivity slider (for mobile controls)
    public void SetSensitivity(float sensitivity)
    {
        touchSensitivityMultiplier = sensitivity;

        // Use this multiplier in your touch input handling script
        // Example: Assuming you have a PlayerTouchController script
        // PlayerTouchController.touchSensitivity = touchSensitivityMultiplier;
    }
}
