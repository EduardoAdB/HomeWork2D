using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class coin : MonoBehaviour
{
    static public coin instance;
    public Rigidbody2D rigbd;

    private void Awake()
    {
        instance = this;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {          
            Debug.Log("pegou a moeda");
            
            coinAudio.instance.Claudio();
            coinparticles.instance.particula();
            Destroy(gameObject);           
        }
    }

}
