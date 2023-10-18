using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public GameObject Avatar;
    public Joystick joystick;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 move = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        GetComponent<CharacterController>().Move(move * Time.deltaTime * Speed);

        Vector3 MovementDirection = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        this.transform.Translate(MovementDirection*Speed*Time.deltaTime,Space.World);

        if (MovementDirection != Vector3.zero)
        {
            Avatar.transform.forward = MovementDirection;
            Avatar.transform.Rotate(new Vector3(0,180,0), Space.World);
        }
        
    }
}
