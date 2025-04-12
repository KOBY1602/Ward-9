using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] AudioSource bgm;
    [SerializeField] AudioSource buttonClick;
    [SerializeField] AudioSource door;
    [SerializeField] AudioSource threatDetectorSwitch;
    [SerializeField] AudioSource threatDetectorState;
    [SerializeField] AudioSource vent;
    [Space(20)]

    public AudioClip ambient;
    

    [Header("--ButtonClick--")]
    public AudioClip buttonClick1;
    public AudioClip buttonClick2;
    public AudioClip buttonClick3;
    [Header("--ThreatState--")]
    public AudioClip Threat1;
    public AudioClip Threat2;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update

    void Start()
    {
        bgm.clip = ambient;
        bgm.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        threatDetectorState.PlayOneShot(Threat1);
        threatDetectorState.PlayOneShot(Threat2);
    }
    

    public void RandomCameraSound()
    {
        int randNum = Random.Range(1, 4);
        switch (randNum)
        {
            case 1:
                buttonClick.PlayOneShot(buttonClick1);
                break;
            case 2:
                buttonClick.PlayOneShot(buttonClick2);
                break;
            case 3:
                buttonClick.PlayOneShot(buttonClick3);
                break;
            default:
                buttonClick.PlayOneShot(buttonClick3);
                break;
        }
    }
    public void ThreatSound(int level, bool isPlaying)
    {
        if (level == 1 && isPlaying)
        {
            threatDetectorState.PlayOneShot(Threat1);
        }        

        if (level == 2 && isPlaying)
        {
            threatDetectorState.PlayOneShot(Threat2);
        }
        else if (!isPlaying)
        {
            threatDetectorState.Stop();
        }
    }
}
