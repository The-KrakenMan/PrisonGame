using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpDetect : MonoBehaviour
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
            GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Random_Encounter>().Bump();
        }
        Destroy(this.transform.parent.gameObject);
    }
}
