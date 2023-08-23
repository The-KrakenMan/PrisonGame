using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bathroom_Enemy : MonoBehaviour
{
    public float Timer;
    public GameObject Exit;
    // Start is called before the first frame update
    void Start()
    {
        int Randomnum = Random.Range(20, 50);
        Timer = Randomnum;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer >= 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            GetComponent<NavMeshAgent>().SetDestination(Exit.transform.position);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Random_Encounter>().Bump();
        }
    }


}
