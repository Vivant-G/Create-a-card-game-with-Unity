using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Navigation : MonoBehaviour
{
    /// <summary>
    /// Name of the current Scene
    /// </summary>
    private string currentSceneName;
    /// <summary>
    /// True: the scene have a fade in effect when open
    /// </summary>
    public bool fadeIn = false;
    /// <summary>
    /// Duration of the fade in effect of the scene
    /// </summary>
    public float fadeInSpeed = 0.5f;
    /// <summary>
    /// True: the scene have a fade out effect when you navigate to another scene
    /// </summary>
    public bool fadeOut = false;
    /// <summary>
    /// Duration of the fade out effect of the scene
    /// </summary>
    public float fadeOutSpeed = 0.5f;
    /// <summary>
    /// Image used for fade effects
    /// </summary>
    public Image fadeImage;

    void Start()
    {
        if (fadeIn) StartCoroutine(FadeIn());
        currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    }

    /// <summary>
    /// Set the current scene as "previous scene". Usefull to navigate back through scenes.
    /// </summary>
    public void SetThisSceneAsPrevious()
    {
        PlayerPrefs.SetString("previousScene", currentSceneName);
    }

    /// <summary>
    /// Navigate to a scene, fade out and it's duration can be modified in the public variables
    /// </summary>
    public void NavigateTo(string destination)
    {
        SetThisSceneAsPrevious();
        if (fadeOut)
        {
            StartCoroutine(FadeOutTo(destination, fadeOutSpeed));
        }
        else UnityEngine.SceneManagement.SceneManager.LoadScene(destination);
    }

    /// <summary>
    /// Navigate to the Scene set as "previous scene".
    /// </summary>
    public void NavigateBack()
    {
        string previousScene = PlayerPrefs.GetString("previousScene");

        if (fadeOut)
        {
            StartCoroutine(FadeOutTo(previousScene, fadeOutSpeed));
        }
        else UnityEngine.SceneManagement.SceneManager.LoadScene(previousScene);
    }

    /// <summary>
    /// Restart the current scene
    /// </summary>
    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneName);
    }

    /// <summary>
    /// Navigate to a scene with a fade out effect
    /// </summary>
    /// <param name="destination">Path to the scene</param>
    /// <param name="time">Duration of the fade out transition</param>
    /// <returns></returns>
    private IEnumerator FadeOutTo(string destination, float time)
    {
        Color currentColor = fadeImage.color;
        while (fadeImage.color.a < 1)
        {
            float alpha = fadeImage.color.a + (Time.deltaTime / time);
            fadeImage.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
            yield return null;
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(destination);
    }

    /// <summary>
    /// Trigger a fade in effect based on the fade in duration public variable
    /// </summary>
    /// <returns></returns>
    public IEnumerator FadeIn()
    {
        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1f); // Initialise la couleur avec une opacité complète
        Color currentColor = fadeImage.color;
        while (fadeImage.color.a > 0)
        {
            float alpha = Mathf.Max(fadeImage.color.a - (Time.deltaTime / fadeInSpeed), 0); // Diminue progressivement l'opacité tout en restant dans la plage [0, 1]
            fadeImage.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
            yield return null;
        }
    }

    public IEnumerator FadeOut(float time, float maxOpacity)
    {
        Color currentColor = fadeImage.color;
        while (fadeImage.color.a < 1)
        {
            float alpha = fadeImage.color.a + (Time.deltaTime / time);
            fadeImage.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
            yield return null;
        }
    }

    public void ExitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
