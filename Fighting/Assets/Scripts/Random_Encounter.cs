using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Encounter : MonoBehaviour
{
    public GameObject LineCutDialogue;
    public GameObject BumpDialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LineCut()
    {
        LineCutDialogue.SetActive(true);
    }

    public void Bump()
    {
        BumpDialogue.SetActive(true);
    }
}
