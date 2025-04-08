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
    private int powerBarNum;
 
    [SerializeField] private Image fillColor;
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

        powerBar.value = powerBarNum;

    }
    private void PowerConsumptionCalc()
    {
        switch (powerUsage)
        {
            case 1:
                fillColor.color = new Color32(0, 255, 0, 255);
                powerBarNum = 20;
                powerConsumption = powerConsumption1;
                break;
            case 2:
                powerConsumption = powerConsumption2;
                powerBarNum = Random.Range(40 -1, 40);
                fillColor.color = new Color32(0, 255, 0, 255);
                break;
            case 3:
                fillColor.color = new Color32(255, 100,0, 255);
                powerBarNum = Random.Range(60 - 1, 60 + 1);
                powerConsumption = powerConsumption3;
                break;
            case 4:
                fillColor.color = new Color32(255, 100, 0, 255);
                powerBarNum = Random.Range(80 - 2, 80 +1);
                powerConsumption = powerConsumption4;
                break;
            case 5:


                fillColor.color = new Color32(255, 0, 0, 255);
                powerBarNum = Random.Range(100 - 5, 100);

                powerConsumption = powerConsumption5;
                break;
        }
    }
}
