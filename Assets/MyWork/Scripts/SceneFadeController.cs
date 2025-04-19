using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneFadeController : MonoBehaviour
{
    public static SceneFadeController Instance;

    public Image fadeImage;
    public float fadeDuration = 1f;

    private void Awake()
    {
        // Singleton pattern to persist across scenes
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Start()
    {
        // Begin fade-in as soon as the scene starts
        fadeImage.color = new Color(0, 0, 0, 1);
        StartCoroutine(Fade(0));
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // After a new scene is loaded, fade in
        StartCoroutine(Fade(0));
    }

    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeAndLoadScene(sceneName));
    }

    private IEnumerator FadeAndLoadScene(string sceneName)
    {
        yield return StartCoroutine(Fade(1)); // Fade to black
        SceneManager.LoadScene(sceneName);    // Load the scene
        // fade-in happens automatically in OnSceneLoaded
    }

    private IEnumerator Fade(float targetAlpha)
    {
        float timeElapsed = 0f;
        float startAlpha = fadeImage.color.a;

        while (timeElapsed < fadeDuration)
        {
            timeElapsed += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, timeElapsed / fadeDuration);
            fadeImage.color = new Color(0, 0, 0, alpha);
            yield return null;
        }

        fadeImage.color = new Color(0, 0, 0, targetAlpha);
    }
}
