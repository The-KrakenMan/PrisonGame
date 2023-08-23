using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Caffeteria_Enemy : MonoBehaviour
{
    public bool InLine = false;
    float Timer;
    Vector3 NewPos = new Vector3(0, 0, 0);

    public GameObject Seat;
    public GameObject Exit;
    public bool LastInLine = false;
    public bool eating = false;

    public float CooldownTimer = 2;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 10;
        NewPos = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Game_Manager.Breakfast == true) || (Game_Manager.Lunch == true) || (Game_Manager.Dinner == true))
        {
            if (eating == false)

                if (InLine == true)
                {
                    if (Timer >= 0)
                    {
                        Timer -= Time.deltaTime;
                    }
                    else
                    {
                        transform.position = Vector3.Lerp(transform.position, NewPos, Time.deltaTime * 2f);
                        CooldownTimer -= Time.deltaTime;
                    }
                    if (CooldownTimer <= 0)
                    {
                        NewPos = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
                        Timer = 10;
                        CooldownTimer = 2;
                    }

                }

                else
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

        }
    }

    IEnumerator WaitCooldown()
    {
        yield return new WaitForSeconds(2);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<Random_Encounter>().Bump();
        }
    }

    public void MoveToSeat()
    {
        if (LastInLine == true)
        {
            Caffeteria_Man.PlayersTurn = true;
        }

        InLine = false;
        GetComponent<NavMeshAgent>().SetDestination(Seat.transform.position);

        int RandomNum = Random.Range(10, 30);
        Timer = RandomNum;
        eating = true;
    }
}
