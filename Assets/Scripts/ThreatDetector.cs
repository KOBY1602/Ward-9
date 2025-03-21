using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreatDetector : MonoBehaviour
{
    public int selectedRoom;
    public List<int> nearbyRooms;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
                nearbyRooms = new List<int>();
                nearbyRooms.Add(4);
                nearbyRooms.Add(7);
                nearbyRooms.Add(8);
                nearbyRooms.Add(6);
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
}
