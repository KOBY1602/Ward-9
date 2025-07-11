using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
   
    public bool isOpenLeft = true;
    public bool isOpenRight = true;
    public GameObject leftHall;
    public GameObject rightHall;
    [SerializeField]private GameObject DoorLeft;
    [SerializeField] private GameObject DoorRight;
    private int random;

    // Start is called before the first frame update
    void Start()
    {
       // image.color = openColor;
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
            AudioManager.instance.DoorLeft(1);
            DoorLeft.SetActive(false);
        }
        else
        {
            AudioManager.instance.DoorLeft(0);
            DoorLeft.SetActive(true);
        }

        
    }
    public void DoorToggleRight()
    {
        isOpenRight = !isOpenRight;

        if (DoorRight.activeSelf)
        {

            AudioManager.instance.DoorRight(1);
            DoorRight.SetActive(false);
        }
        else
        {
            AudioManager.instance.DoorRight(0);

            DoorRight.SetActive(true);
        }
    }
}
