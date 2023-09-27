using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Man : MonoBehaviour
{
    private int Health;

    private bool OnCooldown = false;
    private float HookCooldown = 1;
    public bool isBlocking = false;
    public float Speed;
    

    public GameObject LeftPunchVisual;
    public GameObject RightPunchVisual;

    public static string[] Inventory = new string[5];
    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (OnCooldown == false)
        {
            LeftPunchVisual.SetActive(false);
            RightPunchVisual.SetActive(false);
        }  
        else
        {
            HookCooldown = HookCooldown - Time.fixedDeltaTime;
            if (HookCooldown < 0)
            {
                OnCooldown = false;
            }
        }

     
    }

    public void LeftPunch()
    {
        if (OnCooldown == false)
        {
            OnCooldown = true;
            LeftPunchVisual.SetActive(true);
            HookCooldown = 2;
        }
       
    }

    public void RightPunch()
    {
        if (OnCooldown == false)
        {
            OnCooldown = true;
            RightPunchVisual.SetActive(true);
            HookCooldown = 2;
        }

    }

    public void Block()
    {
        isBlocking = true;
    }

    public void unBlock()
    {
        isBlocking = false;
    }


    public void TakeDamage(int Damage)
    {
        if (isBlocking == false)
        {
            Health = Health - Damage;
        }
       
    }
}
