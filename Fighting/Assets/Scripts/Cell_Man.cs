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
    bool arrested = false;

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
        if (Game_Manager.Hours>= 20 & Game_Manager.Minutes >= 0& Game_Manager.inCell == false )
        {
            Host.SetActive(true);
            GuardDial(1);
            Game_Manager.inCell = true;
            arrested = true;
        }

       if (Game_Manager.Hours == 20 & Game_Manager.Minutes == 00 & Game_Manager.inCell == true & arrested == false)
        {
            this.GetComponent<Game_Manager>().Sleep();
        }

    }

    public void GuardDial(int Dial)
    {   
        Guard1.SetActive(false);
        Guard2.SetActive(false);
        Guard3.SetActive(false);
        

        switch (Dial)
        {
            case 1:
                StartCoroutine(SceneTimer(Guard1,CheckFavour())); break;
            case 2:
                StartCoroutine(SceneTimer(Guard2, 4)); 
                break;
            case 3:
                StartCoroutine(SceneTimer(Guard3, 4)); 
                break;
            case 4:
                Host.SetActive(false);
                this.GetComponent<Game_Manager>().Sleep();
                break;
        }

        
    }

    public int CheckFavour()
    {
        int RandomNum = Random.Range(1, 3);
        if (RandomNum - Game_Manager.WantedLVL > 0)
        {
            return 2;
            
        }
        else
        {
            return 3;
            Game_Manager.PlayerHP -= 50;
        }
    }
     
   IEnumerator SceneTimer(GameObject Scene,int next)
    {
        Scene.SetActive(true);
        yield return new WaitForSeconds(5);
        Scene.SetActive(false);
        GuardDial(next);
    }

}
