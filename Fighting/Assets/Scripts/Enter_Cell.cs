using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enter_Cell : MonoBehaviour
{
    public GameObject Bed;
    // Start is called before the first frame update
    void Start()
    {
        Bed = GameObject.FindGameObjectWithTag("Bed");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<NavMeshAgent>().SetDestination(Bed.transform.position);
            other.GetComponent<NavMeshAgent>().updateRotation = true;
        }
    }
}
