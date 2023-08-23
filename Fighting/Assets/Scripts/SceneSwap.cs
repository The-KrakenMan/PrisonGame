using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Swap2Scene(int val)
    {
        switch (Game_Manager.CurrentLocation)
        {
            case "Bathroom":
                {
                    switch (val)
                    {
                        case 1:
                            SceneManager.LoadScene("Caffeteria");
                            break;

                        case 2:
                            SceneManager.LoadScene("Yard");
                            break;

                        case 3:
                            SceneManager.LoadScene("Prison_Cell");
                            break;
                    }
                }
                break;

            case "Yard":
                {
                    switch (val)
                    {
                        case 1:
                            SceneManager.LoadScene("Caffeteria");
                            break;

                        case 2:
                            SceneManager.LoadScene("Prison_Cell");
                            break;

                        case 3:
                            SceneManager.LoadScene("Bathroom");
                            break;
                    }
                }
                break;

            case "Caffeteria":
                {
                    switch (val)
                    {
                        case 1:
                            SceneManager.LoadScene("Yard");
                            break;

                        case 2:
                            SceneManager.LoadScene("Prison_Cell");
                            break;

                        case 3:
                            SceneManager.LoadScene("Bathroom");
                            break;
                    }
                }
                break;

            case "Prison_Cell":
                {
                    switch (val)
                    {
                        case 1:
                            SceneManager.LoadScene("Caffeteria");
                            break;

                        case 2:
                            SceneManager.LoadScene("Yard");
                            break;

                        case 3:
                            SceneManager.LoadScene("Bathroom");
                            break;
                    }
                }
                break;


        }
       
    }
}
