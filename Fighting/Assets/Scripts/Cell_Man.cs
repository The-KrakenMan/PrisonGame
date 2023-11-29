using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.AI;

public class Cell_Man : MonoBehaviour
{
    public bool Spawn = false;
    public GameObject Host;
    public GameObject Guard1;
    public GameObject Guard2;
    public GameObject Guard3;
    public GameObject Guard4;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Game_Manager.CurrentLocation = "Prison_Cell";
        animator = GetComponent<Animator>();

        for (int i = 0; i < Game_Manager.PrisonerHostility; i++)
        {
            int RandomNum = Random.Range(1, 5);
            Debug.Log(RandomNum);
            if (RandomNum-Game_Manager.PrisonerHostility <= 0)
            {
                Spawn = true;
            }
        }
        if (Spawn == true)
        {
            Enemy.GetComponent<Enemy_AI>().Activated = true;
            Spawn = false;
        }



    }

    // Update is called once per frame
    void Update()
    {
        if (Game_Manager.Hours>= 20 & Game_Manager.Minutes >= 00&Game_Manager.inCell == false)
        {
            Host.SetActive(true);
            GuardDial(1);            
        }

        if (Game_Manager.Hours == 20 & Game_Manager.Minutes == 00 & Game_Manager.inCell == true)
        {
            this.GetComponent<Game_Manager>().Sleep();
        }

    }

    public void GuardDial(int Dial)
    {   
        Guard1.SetActive(false);
        Guard2.SetActive(false);
        Guard3.SetActive(false);
        Guard4.SetActive(false);

        switch (Dial)
        {
            case 1:
                Guard1.SetActive(true);
                break;
            case 2:
                Guard2.SetActive(true);
                break;
            case 3:
                Guard3.SetActive(true);
                break;
            case 4:
                Guard4.SetActive(true);
                break;
            case 5:
                Host.SetActive(false);
                this.GetComponent<Game_Manager>().Sleep();
                break;
        }

        
    }

    public void CheckFavour()
    {
        int RandomNum = Random.Range(1, 3);
        if (RandomNum - Game_Manager.WantedLVL > 0)
        {
            GuardDial(4);
            
        }
        else
        {
            GuardDial(3);
            Game_Manager.PlayerHP -= 50;
        }
    }
     
   

}
