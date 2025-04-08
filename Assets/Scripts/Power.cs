using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float batteryNumber;
    [SerializeField] private int powerUsage;
    [SerializeField] private float powerConsumption;
    [SerializeField] private TextMeshProUGUI batteryNum;
    [Space(20)] 
    [SerializeField] private float powerConsumption1;
    [SerializeField] private float powerConsumption2;
    [SerializeField] private float powerConsumption3;
    [SerializeField] private float powerConsumption4;
    [SerializeField] private float powerConsumption5;

    [Space(20)]
    [SerializeField] private Slider powerBar;
    void Start()
    {
        powerUsage = 1;
        batteryNumber = 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        batteryNumber -= powerConsumption;
        batteryNum.text = Mathf.Floor(batteryNumber).ToString();
        PowerConsumptionCalc();

    }
    private void PowerConsumptionCalc()
    {
        switch (powerUsage)
        {
            case 1:
                powerConsumption = powerConsumption1;
                break;
            case 2:
                powerConsumption = powerConsumption2;
                break;
            case 3:
                powerConsumption = powerConsumption3;
                break;
            case 4:
                powerConsumption = powerConsumption4;
                break;
            case 5:
                powerConsumption = powerConsumption5;
                break;
        }
    }
}
