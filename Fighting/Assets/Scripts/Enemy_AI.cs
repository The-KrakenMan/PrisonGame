using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_AI : MonoBehaviour
{
    public NavMeshAgent Agent;
    public bool Activated = false;
    // Start is called before the first frame update
    void Start()
    {
        Agent = this.gameObject.GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Activated == true)
        {
            Agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
        }
        
    }
}
