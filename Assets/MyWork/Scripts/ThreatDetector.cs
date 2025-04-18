using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ThreatDetector : MonoBehaviour
{
    public static ThreatDetector instance;  
    public SelectedRoom SelectedRoom;
    public List<int> nearbyRooms;

    private int selectedRoom;
    
    [SerializeField] private List<RoomMover> RoomMovers;
    [SerializeField] private List<int> botCurrentRooms;

    [SerializeField] private int dangerLevel;

    [SerializeField] private GameObject green;
    [SerializeField] private GameObject yellow;
    [SerializeField] private GameObject red;
    [SerializeField] private GameObject gray;

    [SerializeField] private GameObject parent;
    private bool playAudio;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.ThreatSound(2, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PressButton()
    {
        selectedRoom = SelectedRoom.selectedRoom;
        botCurrentRooms.Clear();
        foreach (RoomMover item in RoomMovers)
        {
            botCurrentRooms.Add(item.currentRoom);
        }



        NearbyRooms();
        DetectThreats();

        DangerLevelCheck();
    }
    void NearbyRooms()
    {
        switch (selectedRoom)
        {
            case 1:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(3);
                nearbyRooms.Add(2);
                break;
            case 2:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(3);
                nearbyRooms.Add(1);
                nearbyRooms.Add(5);
                break;
            case 3:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(1);
                nearbyRooms.Add(2);
                nearbyRooms.Add(4);
                nearbyRooms.Add(5);
                break;
            case 4:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(3);
                nearbyRooms.Add(5);
                nearbyRooms.Add(6);
                nearbyRooms.Add(9);
                nearbyRooms.Add(8);
                break;
            case 5:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(2);
                nearbyRooms.Add(3);
                nearbyRooms.Add(4);
                nearbyRooms.Add(6);
                break;
            case 6:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(4);
                nearbyRooms.Add(5);
                nearbyRooms.Add(9);
                nearbyRooms.Add(7);
                break;
            case 7:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(6);
                nearbyRooms.Add(8);
                nearbyRooms.Add(9);
                break;
            case 8:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(9);
                nearbyRooms.Add(7);
                nearbyRooms.Add(9);
                nearbyRooms.Add(16);
                break;
            case 9:
                Room9();
                break;
            case 10:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(11);
                break;
            case 11:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(10);
                nearbyRooms.Add(12);
                break;
            case 12:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(11);
                nearbyRooms.Add(13);
                nearbyRooms.Add(14);
                break;
            case 13:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(4);
                nearbyRooms.Add(12);
                nearbyRooms.Add(16);
                nearbyRooms.Add(14);
                break;
            case 14:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(11);
                nearbyRooms.Add(13);
                nearbyRooms.Add(12);
                nearbyRooms.Add(15);
                nearbyRooms.Add(16);
                break;
            case 15:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(14);
                break;
            case 16:
                nearbyRooms = new List<int>();
                nearbyRooms.Add(14);
                nearbyRooms.Add(13);
                nearbyRooms.Add(8);
                break;
        }
    }
    void DetectThreats()
    {
        bool isInSelectedRoom;
        isInSelectedRoom = botCurrentRooms.Contains(selectedRoom);

        
        if (isInSelectedRoom)
        {
            dangerLevel = 3;
        }
        else dangerLevel = 1;
        
        foreach (int nearbyRoom in nearbyRooms)
        {
            
            if (botCurrentRooms.Contains(nearbyRoom) && !isInSelectedRoom)
            {
                dangerLevel = 2;
            }
            
        }
        if (selectedRoom == 9)
        {
            Room9();
        }
    }
    void Room9()
    {
        dangerLevel = 4;
    }
    void DangerLevelCheck() 
    {
        green.SetActive(false);
        yellow.SetActive(false);
        red.SetActive(false);
        gray.SetActive(false);
        switch (dangerLevel)
        {
            case 1:
                green.SetActive(true);
                AudioManager.instance.ThreatSound(1, false);
                break;
            case 2:
                yellow.SetActive(true);
                green.SetActive(true);
                AudioManager.instance.ThreatSound(1, true);
                break;
            case 3:
                red.SetActive(true);
                yellow.SetActive(true);
                green.SetActive(true);
                AudioManager.instance.ThreatSound(2, true);

                break;
            case 4:
                AudioManager.instance.ThreatSound(1, false);
                gray.SetActive(true);
                break;

        }
    }
}
