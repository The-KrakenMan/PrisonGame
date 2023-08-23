using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "Caffeteria")
            {
                SceneManager.LoadScene("Yard");
            }
            if (SceneManager.GetActiveScene().name == "Yard")
            {
                SceneManager.LoadScene("Bathroom");
            }
            if (SceneManager.GetActiveScene().name == "Bathroom")
            {
                SceneManager.LoadScene("Caffeteria");
            }

        }
    }
}
