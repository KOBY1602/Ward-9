using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreatParentControl : MonoBehaviour
{
    public static ThreatParentControl instance;
    private void Awake()
    {
        instance = this;
    }
    private void OnEnable()
    {
        ThreatDetector.instance.PressButton();
    }
    private void OnDisable()
    {
        AudioManager.instance.ThreatSound(1, false);
        Debug.Log("disable");
    }
}
