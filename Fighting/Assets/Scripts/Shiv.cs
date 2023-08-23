using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shiv : MonoBehaviour
{
    public GameObject Prompt;
    
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
            Prompt.SetActive(true);
        }
        GameObject ShivDestroy = GameObject.FindGameObjectWithTag("Knife");
        Destroy(ShivDestroy.gameObject);
    }
}
