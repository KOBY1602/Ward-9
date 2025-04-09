using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room9Bot : MonoBehaviour
{

    [SerializeField] private int stage;
    [SerializeField] private float countDown;
    [SerializeField] private float countDownRate;
    // Start is called before the first frame update
    void Start()
    {
        stage = 1;
        countDown = 100;
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        StageSwitch(countDown);
    }
    void StageSwitch(float countDown)
    {
        // Check which range the countdown is in and update the stage accordingly
        if (countDown <= 20)
        {
            stage = 5; // countdown is 0 or less, set stage to 5
        }
        else if (countDown <= 40)
        {
            stage = 4;
        }
        else if (countDown <= 60)
        {
            stage = 3;
        }
        else if (countDown <= 80)
        {
            stage = 2;
        }
        else if (countDown <= 100)
        {
            stage = 1;
        }
    }
}
