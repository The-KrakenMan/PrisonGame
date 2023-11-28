using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Cell_Man : MonoBehaviour
{
    public bool Spawn = false;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Game_Manager.CurrentLocation = "Prison_Cell";
        animator = GetComponent<Animator>();

        for (int i = 0; i < Game_Manager.PrisonerHostility; i++)
        {
            int RandomNum = Random.Range(1, 10);
            Debug.Log(RandomNum);
            if (RandomNum > 0)
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
        
    }
     
   

}
