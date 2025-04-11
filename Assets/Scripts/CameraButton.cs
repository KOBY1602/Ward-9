using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraButton : MonoBehaviour
{
    public GameObject[] Rooms;
    [SerializeField] public SelectedRoom selectedRoom;

    private GameObject dangerIndicator;
    private ThreatDetector threatDetector;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject room in Rooms)
        {
            if (room != null)
            {
                room.SetActive(false); // Or false to deactivate
            }
        }
        dangerIndicator = GameObject.Find("DangerIndicator");
        threatDetector = dangerIndicator.GetComponent<ThreatDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectRoom(int roomNumber)
    {
        Debug.Log(roomNumber);
        foreach (GameObject room in Rooms)
        {
            if (room != null)
            {
                room.SetActive(false); // Or false to deactivate
            }
        }
        Rooms[roomNumber-1].SetActive(true);
        Debug.Log("Selecting room " + Rooms[roomNumber-1 ]);
        selectedRoom.selectedRoom = roomNumber;
        threatDetector.PressButton();

    }
}
