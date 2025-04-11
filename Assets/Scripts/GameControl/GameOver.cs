using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering.Universal;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    public Volume volume;
    public GameObject postProcessObject;
    private PostProcessVolume postProcess;
    private ColorAdjustments colorAdjustments;

    bool death;
    float elapsedTime;
    float elapsedTime1;
    private Color32 defaultColor = new Color32(255, 255, 255, 255);
    private Color32 deathColor = new Color32(255, 0, 0, 255);
    private Color32 winColor = new Color32(0, 255, 0, 255);


    public float colorChangeTime;
    public float colorChangeTime1;

    private bool blackScreen;
    private bool win;
    private float elapsedTime2;
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        postProcess = postProcessObject.GetComponent<PostProcessVolume>();

        volume.profile.TryGet(out colorAdjustments);


        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (death)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / colorChangeTime);
            colorAdjustments.colorFilter.value = Color32.Lerp(defaultColor, deathColor, t);

        }
        if (blackScreen)
        {
            elapsedTime1 += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime1 / colorChangeTime1);
            colorAdjustments.postExposure.value = Mathf.Lerp(0, -25, t);

        }
        if (win)
        {
            elapsedTime2 += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime2 / colorChangeTime);
            colorAdjustments.colorFilter.value = Color32.Lerp(defaultColor, winColor, t);

        }
    }
    public IEnumerator Death()
    {
        if (!win && !death)
        {
            Debug.Log("Death");
            death = true;
            yield return new WaitForSeconds(1);
            blackScreen = true;
        }
       

    }
    public IEnumerator Victory()
    {
        if (!win && !death)
        {
            Debug.Log("Win");
            win = true;
            yield return new WaitForSeconds(1);
            blackScreen = true;
        }
            

    }
}
