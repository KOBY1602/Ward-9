using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectedRoom_DisplayText : MonoBehaviour

{
    [SerializeField] private SelectedRoom SelectedRoom;
    [SerializeField] private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = SelectedRoom.selectedRoom.ToString();
    }
}
