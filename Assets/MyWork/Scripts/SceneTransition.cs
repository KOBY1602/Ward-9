using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public Image fadeImage; // The image that will fade in and out
    public float fadeDuration = 1f; // Duration of the fade effect

    private void Start()
    {
        // Initially set the fadeImage to transparent
        fadeImage.color = new Color(0f, 0f, 0f, 0f);
    }

    // Call this method to start the fade-out and scene transition
    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeAndSwitchScene(sceneName));
    }

    private IEnumerator FadeAndSwitchScene(string sceneName)
    {
        // Fade to black
        yield return StartCoroutine(Fade(1f));

        // Load the next scene
        SceneManager.LoadScene(sceneName);

        // Wait until the new scene is fully loaded
        yield return new WaitForSeconds(0.5f); // You can adjust this time

        // Fade back to transparent
        yield return StartCoroutine(Fade(0f));
    }

    private IEnumerator Fade(float targetAlpha)
    {
        float timeElapsed = 0f;
        float startingAlpha = fadeImage.color.a;

        while (timeElapsed < fadeDuration)
        {
            timeElapsed += Time.deltaTime;
            float alpha = Mathf.Lerp(startingAlpha, targetAlpha, timeElapsed / fadeDuration);
            fadeImage.color = new Color(0f, 0f, 0f, alpha); // Adjust the alpha value
            yield return null;
        }

        // Ensure the final alpha is exactly what we want
        fadeImage.color = new Color(0f, 0f, 0f, targetAlpha);
    }
}

