﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioBackground : MonoBehaviour
{
    public AudioSource backgroundCave;
    public AudioSource backgroundFirst;
    public AudioSource backgroundSecond;
    // Start is called before the first frame update
    void Start()
    {
        backgroundCave.loop = true;
        backgroundCave.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
