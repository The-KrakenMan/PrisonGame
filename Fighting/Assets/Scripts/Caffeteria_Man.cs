using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caffeteria_Man : MonoBehaviour
{
    public static bool PlayersTurn = false;
    public bool hasFood = false;
    public GameObject Objective1;
    public GameObject Objective2;
    public GameObject Objective3;
    public GameObject NotServing;
    // Start is called before the first frame update
    void Start()
    {
        Game_Manager.CurrentLocation = "Caffeteria";
        Game_Manager.Breakfast = false;
        Game_Manager.Lunch = false;
        Game_Manager.Dinner = false;
        NotServing.SetActive(true);

        if (Game_Manager.Hours <7)
        {
            if (Game_Manager.Hours > 6)
            {
                Game_Manager.Breakfast = true;
                Objective1.SetActive(true);
                NotServing.SetActive(false);
            }
        }
        else
        {
            if (Game_Manager.Hours < 13)
            {
                if (Game_Manager.Hours > 12)
                {
                    Game_Manager.Lunch = true;
                    Objective1.SetActive(true);
                    NotServing.SetActive(false);
                }
            }

            else
            {
                if (Game_Manager.Hours < 18)
                {
                    if (Game_Manager.Hours > 17)
                    {
                        Game_Manager.Dinner = true;
                        Objective1.SetActive(true);
                        NotServing.SetActive(false);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_Manager.Hours < 7)
        {
            if (Game_Manager.Hours == 6)
            {
                Game_Manager.Breakfast = true;
                Objective1.SetActive(true);
                NotServing.SetActive(false);
            }
        }
        else
        {
            if (Game_Manager.Hours < 13)
            {
                if (Game_Manager.Hours == 12)
                {
                    Game_Manager.Lunch = true;
                    Objective1.SetActive(true);
                    NotServing.SetActive(false);
                }
            }

            else
            {
                if (Game_Manager.Hours < 18)
                {
                    if (Game_Manager.Hours == 17)
                    {
                        Game_Manager.Dinner = true;
                        Objective1.SetActive(true);
                        NotServing.SetActive(false);
                    }
                }
            }
        }
    }

    public void CollectFood()
    {
        Game_Manager.PlayerHP += 10;
        Objective1.SetActive(false);
        Objective2.SetActive(true);
        hasFood = true;
    }

    public void Ate()
    {
        Objective3.SetActive(true);
        Objective2.SetActive(false);
        Game_Manager.PlayerHP += 5;
    }
}
