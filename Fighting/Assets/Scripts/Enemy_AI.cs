using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_AI : MonoBehaviour
{
    public NavMeshAgent Agent;
    public bool Activated = false;
    public GameObject Player;
    public Animator EnemyAnim;
    //public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Agent = this.gameObject.GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
        EnemyAnim= GetComponent<Animator>();
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Activated == true)
        {
            Agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
            //EnemyAnim.SetBool("isWalking", true); 
            EnemyAnim.SetInteger("Anim", 3);
           

        }

        this.transform.LookAt(Player.transform);

       
        
    }

    public void PlayGettingHitAnimation()
    {
        if (EnemyAnim != null)
        {
            EnemyAnim.SetInteger("Anim", 2); // Assuming you have a trigger parameter named "GettingHit" in your animator
        }
    }
}
