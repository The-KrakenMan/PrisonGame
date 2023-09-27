using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class INTERACTION_MAN : MonoBehaviour
{
    public GameObject Output1;
    public GameObject Output2;
    public GameObject Output3;
    public GameObject Output4;
    public GameObject Output5;

 

    public GameObject ButtonHide1;
    public GameObject ButtonHide2;

    public GameObject TextHide1;

    public GameObject Host;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StealKnife()
    {
        int RandomNum = Random.Range(1, 10);
        if (RandomNum + Game_Manager.WantedLVL > 5)
        {
            Game_Manager.WantedLVL += 2;
            Output1.SetActive(true);        
        }
        else
        {
            Game_Manager.PlayerDMG += 10;
            Output2.SetActive(true);
            Player_Man.Inventory[0] = "Knife";
            Debug.Log("InteractionMan");
        }

        ButtonHide1.SetActive(false);
        ButtonHide2.SetActive(false);
        TextHide1.SetActive(false);

        
    }

    public void ReportKnife()
    {
        Game_Manager.PrisonerHostility += 2;
        Game_Manager.WantedLVL -= 1;
        Output3.SetActive(true);

        ButtonHide1.SetActive(false);
        ButtonHide2.SetActive(false);
        TextHide1.SetActive(false);
    }

    public void Close()
    {
        Destroy(this.gameObject);
    }


    public void LineCut(int Dialogue)
    {
        Deactivate();
        switch (Dialogue)
        {
            case 1:
                Output1.SetActive(true);
                break;

            case 2:
                Output2.SetActive(true);
                break;
            case 3:
                Output3.SetActive(true);
                break;
            case 4:
                {
                    int RandomNum = Random.Range(1, 10) + Game_Manager.PrisonerHostility;
                    if (RandomNum < 5)
                    {
                        Output4.SetActive(true);
                    }
                    else
                    {
                        Output5.SetActive(true);
                        Game_Manager.PlayerHP -= 10;
                    }
                }
                break;
            case 5:
                Deactivate();
                Host.SetActive(false);
                break;

        }    



    }
   

    public void Deactivate()
    {
        Output1.SetActive(false);
        Output2.SetActive(false);
        Output3.SetActive(false);
        Output4.SetActive(false);
        Output5.SetActive(false);
    }


    public void Fight()
    {
        SceneManager.LoadScene("Fighting");
    }






}
