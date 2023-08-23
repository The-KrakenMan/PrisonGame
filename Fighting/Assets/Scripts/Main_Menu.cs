using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject How2Play;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(int val)
    {
        switch (val)
        {
            case 0:
                How2Play.SetActive(true);
                break;
            case 1:
                SceneManager.LoadScene("Prison_Cell");
                break;
        }
        
    }
}
