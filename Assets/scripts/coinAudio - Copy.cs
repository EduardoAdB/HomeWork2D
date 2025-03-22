using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class coinAudio : MonoBehaviour
{
    public static coinAudio instance;
    public AudioSource Moeda;
    public int coincount;
    public TextMeshProUGUI coinTxt;    

    private void Start()
    {
        coincount = 0;
    }
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {    
        coinTxt.text = ("moedas: "+coincount.ToString());
    }

    public void Claudio()
    {
        Moeda.Play();       
        coincount++;
    }
}
