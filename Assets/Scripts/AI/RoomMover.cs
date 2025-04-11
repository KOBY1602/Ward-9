using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomMover : MonoBehaviour
{
    public int startRoom;
    public int currentRoom;
    public float timer;
    public float timerReset;
    
    public int randNumber;
    
    public bool canMove;


    //Door
    public float doorTimerReset;
    public float doorTimer;

    public float doorTimerResetMin;
    public float doorTimerResetMax;


    [SerializeField] private DoorController[] doorController;
    
    public enum Difficulty
    {
        FirstLevel,
        Easy,
        Normal,
        Hard
    }
    public Difficulty difficultyChoice;

    public GameObject bot1;
    public Text bot1Text;


    public bool in101;
    public bool in102;
    
    // Start is called before the first frame update
    void Start()
    {
        currentRoom = startRoom;
        canMove = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {




        timer += Time.deltaTime;
        if (timer >= timerReset && canMove)
        {
            timer = 0;
            if (RandomMoveNumber() < GetDifficult() )
            {
                ToNextRoom();
                Debug.Log("Move");
            }
            else Debug.Log("Dont Move");
        }

        bot1Text.text = currentRoom.ToString();

       if (in101)
        {

            doorTimer += Time.deltaTime;
             
            if (doorTimer >= doorTimerReset)
            {
                doorTimer = 0;
                if (!doorController[1].isOpenLeft)
                {
                    Retreat();
                    in101 = false;

                    //reset to normal state
                    canMove = true;
                    timer = 0;
                }
                else
                {
                    in101 = false;

                    currentRoom = 200;
                    StartCoroutine(GameOver.instance.Death());
                }
            }
        }
        if (in102)
        {

            doorTimer += Time.deltaTime;
            
            if (doorTimer >= doorTimerReset)
            {
                doorTimer = 0;
                if (!doorController[0].isOpenRight)
                {
                    Retreat();

                    in102 = false;
                    //reset to normal state
                    canMove = true;
                    timer = 0;

                }
                else
                {
                    in102 = false;

                    currentRoom = 200;
                    StartCoroutine(GameOver.instance.Death());
                }
            }
        }


    }
    //Room101: LeftHall
    //Room102: RightHall
    //Room 200: PlayerRoom
    void NextRoom_101()
    {
        canMove = false;
        doorTimerReset = Random.Range(doorTimerResetMin, doorTimerResetMax);
        in101 = true;
        


    }
    void NextRoom_102()
    {
        canMove = false;
        doorTimerReset = Random.Range(doorTimerResetMin, doorTimerResetMax);
        in102 = true;
    }
    int RandomMoveNumber()
    {
        randNumber = Random.Range(1, 21);
        return randNumber;
    }

    int GetDifficult()
    {
        switch (difficultyChoice)
        {
            case Difficulty.FirstLevel:
                return 1;
            case Difficulty.Easy:
                return 3;
            case Difficulty.Normal:
                return 7;
            default:
                return 15;
        }
    }




    void NextRoom_1()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 4)
        {
            currentRoom = 3;
        }
        else if (randNumber >4 && randNumber <= 7)
        {
            currentRoom = 10;
        }
        else currentRoom = 4;
    }
    void NextRoom_2()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 4)
        {
            currentRoom = 3;
        }
        
        else currentRoom = 5;
    }
    void NextRoom_3()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 4)
        {
            currentRoom = 4;
        }

        else currentRoom = 5;
    }
    void NextRoom_4()
    {
        int randNumber = Random.Range(1, 6);
        switch (randNumber)
        {
            case 1:
                currentRoom = 10; break;
            case 2:
                currentRoom = 11; break;
            case 3:
                currentRoom = 6; break;
            case 4:
                currentRoom = 8; break;
            case 5:
                currentRoom = 13; break;
        }
    }
    void NextRoom_5()
    {
        int randNumber = Random.Range(1, 3);
        switch (randNumber)
        {
            case 1:
                currentRoom = 4; break;
            case 2:
                currentRoom = 6; break;        
        }
    }
    void NextRoom_6()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 3)
        {
            currentRoom = 4;
        }

        else currentRoom = 7;
    }
    void NextRoom_7()
    {
        currentRoom = 8;
    }
    void NextRoom_8()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 7)
        {
            currentRoom = 102;
        }

        else currentRoom = 16;
    }
    //vent
    void NextRoom_9()
    {
         
    }
    void NextRoom_10()
    {
        currentRoom = 11;
    }
    
    void NextRoom_11()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 4)
        {
            currentRoom = 12;
        }
        else if (randNumber > 4 && randNumber <= 7)
        {
            currentRoom = 14;
        }
        else currentRoom = 15;
    }
    void NextRoom_12()
    {
        currentRoom = 13;
    }
    void NextRoom_13()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 2)
        {
            currentRoom = 4;
        }

        else currentRoom = 14;
    }
    void NextRoom_14()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 3)
        {
            currentRoom = 15;
        }

        else currentRoom = 16;
    }
    void NextRoom_15()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 1)
        {
            currentRoom = 14;
        }

        else currentRoom = 101;
    }
    void NextRoom_16()
    {
        int randNumber = Random.Range(1, 11);
        if (randNumber <= 3)
        {
            currentRoom = 8;
        }

        else currentRoom = 101;
    }
    void NextRoom_200()
    {
        StartCoroutine(GameOver.instance.Death());
    }
    void Retreat()
    {
        currentRoom = Random.Range(1, 11);
        if (currentRoom == 9)
        {
            currentRoom = Random.Range(1, 11);
        }
        else { }
    }
    public void ToNextRoom()
    {
        switch (currentRoom)
        {
            case 1:
                NextRoom_1();
                break;
            case 2:
                NextRoom_2();
                break;
            case 3:
                NextRoom_3();
                break;
            case 4:
                NextRoom_4();
                break;
            case 5:
                NextRoom_5();
                break;
            case 6:
                NextRoom_6();
                break;
            case 7:
                NextRoom_7();
                break;
            case 8:
                NextRoom_8();
                break;
            case 9:
                NextRoom_9();
                break;
            case 10:
                NextRoom_10();
                break;
            case 11:
                NextRoom_11();                  
                break;
            case 12:
                NextRoom_12();                   
                break;
            case 13:
                NextRoom_13();
                break;
            case 14:
                NextRoom_14();
                break;
            case 15:
                NextRoom_15();
                break;
            case 16:
                NextRoom_16();
                break;
            case 101:
                NextRoom_101();
                break;
            case 102:
                NextRoom_102();
                break;
            case 200:
                NextRoom_200();
                break;

        }
    }
}
