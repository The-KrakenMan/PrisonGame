using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Seat : MonoBehaviour
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
        if (other.tag == "Enemy")
        {
            other.GetComponent<NavMeshAgent>().SetDestination(other.transform.position);
        }
        else
        {
            if (other.tag == "Player")
            {
                if (GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Caffeteria_Man>().hasFood == true)
                {                 
                    GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Caffeteria_Man>().Ate();
                }
            }
        }
    }
}
