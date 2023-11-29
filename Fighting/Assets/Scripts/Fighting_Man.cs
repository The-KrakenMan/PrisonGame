using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Fighting_Man : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public float EnemyHealth = 50;
    public float AttackTimer;
    public int RandomNum;
    public int Damage;
    Animator player_anim;
    Animator enemy_anim;

    // Start is called before the first frame update
    void Start()
    {
        RandomNum = Random.Range(1, 5);
        Player = GameObject.FindGameObjectWithTag("Player");
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        AttackTimer = RandomNum;
        Damage = RandomNum;
         player_anim = Player.GetComponent<Animator>();
         enemy_anim = Enemy.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Player.GetComponent<Player_Man>().LeftPunch();
            DamageEnemy(Game_Manager.PlayerDMG);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Player.GetComponent<Player_Man>().RightPunch();
            DamageEnemy(Game_Manager.PlayerDMG);
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
            enemy_anim.SetTrigger("Punch");
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

    public void DamageEnemy(int DMG)
    {
        EnemyHealth -= DMG;
       
        enemy_anim.SetTrigger("GetHit");

    }




}
