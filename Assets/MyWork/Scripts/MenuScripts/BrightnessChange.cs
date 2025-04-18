using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BrightnessChange : MonoBehaviour
{
    private Light2D light2D;
    bool limitReached = false;
    // Start is called before the first frame update
    void Start()
    {
        light2D = this.gameObject.GetComponent<Light2D>();
        StartCoroutine(Flash());
    }

    // Update is called once per frame
    void Update()
    {
        if (light2D.intensity < 30 && limitReached == false)
        {
            light2D.intensity +=  100*Time.deltaTime;
            
            if(light2D.intensity >= 30)
            {
                limitReached = true;
            }
        }
        if (limitReached == true)
        {
            light2D.intensity -= 30 * Time.deltaTime;
            if (light2D.intensity <= 3)
            {
                light2D.intensity = 3;
            }
        }
    }
    IEnumerator Flash()
    {
        Debug.Log("Flash");
        light2D.intensity = 0;
        yield return new WaitForSeconds(0.5f);
       
    }
}
