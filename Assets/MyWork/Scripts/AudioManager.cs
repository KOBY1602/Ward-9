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

    [SerializeField] AudioSource doorLeft;
    [SerializeField] AudioSource doorRight;

    [SerializeField] AudioSource threatDetectorSwitch;
    [SerializeField] AudioSource threatDetectorState;
    [SerializeField] AudioSource threatDetectorState1;

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
    [Space(10)]
    public AudioClip Threat11;
    public AudioClip Threat12;
    public AudioClip Threat13;
    [Header("--Door--")]
    public AudioClip doorClose;
    public AudioClip doorOpen;


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
        if (ThreatParentControl.instance.gameObject.activeSelf )
        {
            //for normal Rooms
            if (level == 1 && isPlaying  )
            {
                threatDetectorState.Stop();
                Debug.Log("Level1");
                threatDetectorState.clip = Threat1;
                threatDetectorState.Play();
            }

            if (level == 2 && isPlaying )
            
            {
                threatDetectorState.Stop();
                Debug.Log("Level2");

                threatDetectorState.clip = Threat2;
                threatDetectorState.Play();
            }
            if(level == 11 && isPlaying)
            {
                threatDetectorState.Stop();
                Debug.Log("Level11");

                threatDetectorState.clip = Threat11;
                threatDetectorState.Play();
            }
            if (level == 12 && isPlaying)
            {
                threatDetectorState.Stop();
                Debug.Log("Level12");

                threatDetectorState.clip = Threat12;
                threatDetectorState.Play();
            }
            if (level == 13 && isPlaying)
            {

            }
            else if (!isPlaying)
            {
                threatDetectorState.Stop();
            }

        }
        else
        {
            threatDetectorState.Stop();
        }


    }

    //2 door functions so sound overlaps instead of stopping each other
    public void DoorLeft(int action)
        //action == 0 (close), 1 (open)
    {
        switch (action)
        {
            case 0:
                doorLeft.PlayOneShot(doorClose); 
                break;
            case 1:
                doorLeft.PlayOneShot(doorOpen);
                break;
        }
    }
    public void DoorRight(int action)
    //action == 0 (close), 1 (open)
    {
        switch (action)
        {
            case 0:
                doorRight.PlayOneShot(doorClose);
                break;
            case 1:
                doorRight.PlayOneShot(doorOpen);
                break;
        }
    }

}
