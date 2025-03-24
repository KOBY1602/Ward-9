using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class DoorController : MonoBehaviour
{
   
    public bool isOpenLeft = true;
    public bool isOpenRight = true;
    public GameObject leftHall;
    public GameObject rightHall;
    [SerializeField]private GameObject DoorLeft;
    [SerializeField] private GameObject DoorRight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoorToggle(int side)
    {
        switch (side)
        {
            case 1:
                DoorLeft = leftHall;
                if (isOpenLeft)
                {
                    Debug.Log("close");
                    DoorLeft.SetActive(false);
                }
                else
                {
                    Debug.Log("open");
                    DoorLeft.SetActive(true);
                }
                isOpenLeft = !isOpenLeft;
                break;

            case 2:
                DoorRight = rightHall;
                if (isOpenRight)
                {
                    Debug.Log("close");
                    DoorRight.SetActive(false);
                }
                else
                {
                    Debug.Log("open");
                    DoorRight.SetActive(true);
                }
                isOpenRight = !isOpenRight;
                break;
        }


    }
}
