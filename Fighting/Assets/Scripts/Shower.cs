using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shower : MonoBehaviour
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
        GameObject.FindGameObjectWithTag("Objective").SetActive(false);
        Destroy(this.gameObject);
    }
}
