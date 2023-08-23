using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((Game_Manager.Breakfast == true) || (Game_Manager.Lunch == true) || (Game_Manager.Dinner == true))
        {
            if (other.gameObject.tag == "Player")
            {
                if (Caffeteria_Man.PlayersTurn == false)
                {
                    GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Random_Encounter>().LineCut();
                }
                else
                {
                    GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Caffeteria_Man>().CollectFood();
                    Caffeteria_Man.PlayersTurn = false;
                }
            }

            if (other.gameObject.tag == "Enemy")
            {
                other.GetComponent<Caffeteria_Enemy>().MoveToSeat();
                if (other.GetComponent<Caffeteria_Enemy>().LastInLine == true)
                {
                    Caffeteria_Man.PlayersTurn = true;
                }
            }
        }
        else
        {

        }
    }
}
