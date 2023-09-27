using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_MAN : MonoBehaviour
{
    public GameObject KnifePic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Player_Man.Inventory[0] == "Knife")
        {
            KnifePic.SetActive(true);
            Debug.Log("Inventory_man");
        }
    }
}
