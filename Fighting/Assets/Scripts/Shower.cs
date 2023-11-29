using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Game_Manager.DayShower == Game_Manager.DayCount)
        {
            Destroy(this.gameObject);
            GameObject.FindGameObjectWithTag("Objective").SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindGameObjectWithTag("Objective").SetActive(false);
        Game_Manager.DayShower = Game_Manager.DayCount;
        Game_Manager.PrisonerHostility -= 3;
        Destroy(this.gameObject);
    }
}
