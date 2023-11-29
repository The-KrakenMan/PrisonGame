using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public GameObject Player;
    public static string CurrentLocation;
    public static float Minutes= 45;
    public static float Hours = 19;
    public static int WantedLVL;
    public static int PrisonerHostility = 1;
    public static float PlayerHP = 100;
    public static int PlayerDMG = 2;
    public float Timer = 0;
    public TextMeshProUGUI TimerOut;
    public Slider HealthBar;
    public GameObject GameOverScreen;
    public static int DayCount = 1;
    public static int DayShower;
    public static bool inCell=true;

    public static bool Showered;
    public static bool Breakfast;
    public static bool Lunch;
    public static bool Dinner;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Hours> 20)
        {
            if (CurrentLocation == "Prison Cell")
            {

            }
            else
            {
                GameOver();
            }
        }


        if (PlayerHP <= 0)
        {
            GameOver();
        }

        if (PlayerHP > 100)
        {
            PlayerHP = 100;
        }
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Sleep()
    {
        DayCount++;
        SceneManager.LoadScene("Prison_Cell");
        Hours = 5;
        Minutes = 0;
    }
    private void FixedUpdate()
    {
        HealthBar.value = (1 - (PlayerHP / 100));
        if (Timer <=0)
        {
            Timer = 1;
            Minutes++;
            if (Minutes == 60)
            {
                Hours++;
                Minutes = 0;
            }
        }  
        else
        {
            Timer -= Time.fixedDeltaTime;
            Timer -= Time.fixedDeltaTime;
        }


        if (Minutes < 10)
        {
            TimerOut.text = (Hours + ":0" + Minutes);
        }
        else
        {
            TimerOut.text = (Hours + ":" + Minutes);
        }
       
    }


}
