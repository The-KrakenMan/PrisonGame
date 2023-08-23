using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GymStart : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGymming;
    public int ClickCounter = 0;
    public float QTE_Timer;
    public TextMeshProUGUI TimerOutput;
    public TextMeshProUGUI ClickOutput;
    public TextMeshProUGUI StrengthGained;
    public GameObject GymQuery;
    public GameObject GymUI;
    public GameObject GymResults;
    public GameObject GymCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerOutput.text = QTE_Timer.ToString();
        ClickOutput.text = ClickCounter.ToString();
        if (isGymming == true)
        {
            if (QTE_Timer >0)
            {
                QTE_Timer -= Time.deltaTime;
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Works");
                    ClickCounter++;
                }
            }
            else
            {
                isGymming = false;
                GymScene(2);
                GymCamera.SetActive(false);
                GymResults.SetActive(true);
                StrengthGained.text = (ClickCounter / 20).ToString();
                Game_Manager.PlayerDMG += (ClickCounter / 20);
                Game_Manager.Hours += 2;
            }
           
            

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GymScene(0);
        }
    }

    public void GymScene(int Tracker)
    {
        switch (Tracker)
        {
            case 0:
                GymQuery.SetActive(true);
                break;
            case 1:
                {
                    GymQuery.SetActive(false);
                    isGymming = true;
                    QTE_Timer = 10;
                    GymUI.SetActive(true);
                    GymCamera.SetActive(true);          
                }
                break;
            case 2:
                {
                    GymQuery.SetActive(false);
                    GymUI.SetActive(false);
                    GymResults.SetActive(false);
                    GymCamera.SetActive(false);
               }
                break;
        }
        
    }

    

}
