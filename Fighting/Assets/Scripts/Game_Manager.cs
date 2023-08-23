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
    public static float Minutes= 0;
    public static float Hours = 5;
    public static int WantedLVL;
    public static int PrisonerHostility = 1;
    public static float PlayerHP = 100;
    public static int PlayerDMG = 2;
    public float Timer = 0;
    public TextMeshProUGUI TimerOut;
    public Slider HealthBar;
    public GameObject GameOverScreen;

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
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene("Main_Menu");
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
