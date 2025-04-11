using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedRoom : MonoBehaviour
{
    public static SelectedRoom instance;
    public int selectedRoom;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        selectedRoom = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
