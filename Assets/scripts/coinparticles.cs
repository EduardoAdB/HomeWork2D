using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class coinparticles : MonoBehaviour
{
    public static coinparticles instance;
    public ParticleSystem dinheiro;

    private void Awake()
    {
        instance = this;

    }
    private void Start()
    {
        dinheiro = GetComponent<ParticleSystem>();
       
    }
    private void Update()
    {
        if (dinheiro == null)
        {
            
            dinheiro = GetComponent<ParticleSystem>();
        }
    }

    public void particula()
    {
        dinheiro.Play();
    }

}
