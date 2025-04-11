using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float seconds = 300;
    private string time;
    public TextMeshProUGUI text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
       
        text.text = time;
        timeDisplay();
        if (seconds < 0)
        {
            StartCoroutine(GameOver.instance.Victory());

        }
    }
    private void timeDisplay()
    {
        if (seconds >= 250)
        {
            time = "12AM";
        }
        else if (seconds >= 200)
        {
            time = "1AM";
        }
        else if (seconds >= 150)
        {
            time = "2AM";
        }
        else if (seconds >= 100)
        {
            time = "3AM";
        }
        else if (seconds >= 50)
        {
            time = "4AM";
        }
        else if (seconds > 0)
        {
            time = "5AM";
        }
        else { time = "6AM"; }
    }
}
