using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincolision : MonoBehaviour
{
    public ParticleSystem money;
    public Rigidbody2D rgb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            money.Play();
        }
    }
}
