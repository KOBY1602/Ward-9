using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CameraBackgroundChange : MonoBehaviour
{
    private Camera camera;

    private Color32 originalColor = new Color32(0, 0, 0, 0);
    private Color32 endColor = new Color32(37, 35, 43, 255);

    public float colorChangeTime;
    float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        camera = this.gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        float t = Mathf.Clamp01(elapsedTime / colorChangeTime);
        camera.backgroundColor = Color32.Lerp(originalColor, endColor, t);
        
    }
}
