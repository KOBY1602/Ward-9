using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static RoomMover;

public class Room9Bot : MonoBehaviour
{

    [SerializeField] private int stage;
    [SerializeField] private float countDown;
    [SerializeField] private float countDownRate;

    public float timer;
    [SerializeField] private float timerReset;
    
    private bool canMove;
    private int randNumber;

    [Space(20)]
    public Difficulty difficultyChoice;

   
    public enum Difficulty
    {
        FirstLevel,
        Easy,
        Normal,
        Hard
    }
    
    // Start is called before the first frame update
    void Start()
    {
        stage = 1;
        countDown = 100;
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= timerReset && canMove)
        {
            timer = 0;
            if (RandomMoveNumber() < GetDifficult())
            {
                ToNextStage();
                Debug.Log("Room 9 NextStage");
            }
           
        }
        if (SelectedRoom.instance.selectedRoom == 9)
        {
            timer = 0;
        }
        else { }
    }
    void ToNextStage()
    {
        stage++;
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
    int RandomMoveNumber()
    {
        randNumber = Random.Range(1, 21);
        return randNumber;
    }
  
}
