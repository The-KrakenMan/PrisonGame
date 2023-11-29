using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell_Enter : MonoBehaviour
{
    // Start is called before the first frame update
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
           Game_Manager.inCell = true;
          
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Game_Manager.inCell = false;
         
        }
    }
}
