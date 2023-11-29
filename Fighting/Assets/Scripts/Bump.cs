
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bump : MonoBehaviour
{
    public GameObject BumpOutput1;
    public GameObject BumpOutput2;
    public GameObject BumpOutput3;
    public GameObject BumpOutput4;

    public GameObject Host;
    // Start is called before the first frame update
    void Start()
    {
        Game_Manager.PrisonerHostility += 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BumpDial(int Dialogue)
    {
        BumpDeactivate();
        switch (Dialogue)
        {
            case 1:
                BumpOutput1.SetActive(true);
                break;

            case 2:
                {
                    int RandomNum = Random.Range(1, 10) + Game_Manager.PrisonerHostility;
                    if (RandomNum < 5)
                    {
                        BumpOutput2.SetActive(true);
                    }
                    else
                    {
                        BumpOutput3.SetActive(true);
                    }
                }
                break;
            case 3:
                SceneManager.LoadScene("Fighting");
                break;
            case 4:
                BumpDeactivate();
                Host.SetActive(false);
                BumpOutput1.SetActive(true);
                break;

        }
    }
    public void BumpDeactivate()
    {
        Debug.Log("Flag");
        BumpOutput1.SetActive(false);
        BumpOutput2.SetActive(false);
        BumpOutput3.SetActive(false);
        BumpOutput4.SetActive(false);
    }
}
