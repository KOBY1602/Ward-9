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

    public void DoorToggleLeft()
    {
        isOpenLeft = !isOpenLeft;
        
        if (DoorLeft.activeSelf)
        {
            DoorLeft.SetActive(false);
        }
        else
        {
            DoorLeft.SetActive(true);
        }
    }
    public void DoorToggleRight()
    {
        isOpenRight = !isOpenRight;

        if (DoorRight.activeSelf)
        {
            DoorRight.SetActive(false);
        }
        else
        {
            DoorRight.SetActive(true);
        }
    }
}
