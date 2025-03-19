using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class animations : MonoBehaviour
{
    public Animator Warrior;
    private void Start()
    {        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Warrior.SetBool("Run", true);
        }  
        if (Input.GetKeyUp(KeyCode.A))
        {
            Warrior.SetBool("Run", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Warrior.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Warrior.SetBool("Run", false);
        }
    

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Warrior.SetBool("Jump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Warrior.SetBool("Jump", false);
            Warrior.SetBool("Fall", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Warrior.SetBool("Fall", false);
        }
    }
}
