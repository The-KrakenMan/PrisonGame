using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpDetect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ME;
    Caffeteria_Enemy INCAF;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            INCAF = ME.GetComponent<Caffeteria_Enemy>();
            if (INCAF != null)
            {
                if (ME.GetComponent<Caffeteria_Enemy>().InLine == true)
                {
                    GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Random_Encounter>().LineCut();
                }
                else
                {
                    GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Random_Encounter>().Bump();
                }
            }
            else
            {
                GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Random_Encounter>().Bump();
            }
           
          
            
        }
      
    }
}

