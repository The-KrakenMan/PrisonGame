using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Fighting_Man : MonoBehaviour
{
    public GameObject Player;
    public float EnemyHealth = 50;
    public float AttackTimer;
    public int RandomNum;
    public int Damage;
    Animator animator;
    Enemy_AI enemy_AI;

    // Start is called before the first frame update
    void Start()
    {
        RandomNum = Random.Range(1, 5);
        Player = GameObject.FindGameObjectWithTag("Player");
        AttackTimer = RandomNum;
        Damage = RandomNum;
        animator = GetComponent<Animator>();
        enemy_AI = GetComponent<Enemy_AI>();
       
   

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Player.GetComponent<Player_Man>().LeftPunch();
            EnemyHealth -= Game_Manager.PlayerDMG;


            //if (enemy_AI.Activated && EnemyHealth > 0)
            //{
            //    enemy_AI.PlayGettingHitAnimation(); // Call the method to play the getting_hit animation
            //}

        }
        if (Input.GetMouseButtonDown(1))
        {
            Player.GetComponent<Player_Man>().RightPunch();
            EnemyHealth -= Game_Manager.PlayerDMG;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.GetComponent<Player_Man>().Block();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Player.GetComponent<Player_Man>().unBlock();
        }

        if (AttackTimer > 0)
        {
            AttackTimer -= Time.deltaTime;
        }
        else
        {
            if (Player.GetComponent<Player_Man>().isBlocking)
            {

            }
            else
            {
                Game_Manager.PlayerHP -= Damage;
                int RandomNum2 = Random.Range(1, 5);
                AttackTimer = RandomNum2;
                Damage = RandomNum2;
            }
        }

        if (EnemyHealth <=0 )
        {
            SceneManager.LoadScene(Game_Manager.CurrentLocation); 
        }

    }




}
