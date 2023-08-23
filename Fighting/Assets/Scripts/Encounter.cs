using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Encounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Enemy").GetComponent<NavMeshAgent>().isStopped = true;
        }

        GameObject.FindGameObjectWithTag("Enemy").GetComponent<Random_Encounter>().Bump();
    }
}
