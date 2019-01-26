using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioBackground : MonoBehaviour
{
    public AudioSource backgroundCave;
    public AudioSource backgroundFirst;
    public AudioSource backgroundSecond;

    public int audioNumber;
    // Start is called before the first frame update
    void Start()
    {
        backgroundCave.loop = true;
        backgroundFirst.loop = true;
        backgroundSecond.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            audioNumber += 1;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            audioNumber -= 1;
        }

        if(audioNumber == 0 && !backgroundCave.isPlaying)
        {
            backgroundCave.Play();
            backgroundFirst.Stop();
            backgroundSecond.Stop();
        }
        else if (audioNumber == 1 && !backgroundFirst.isPlaying)
        {
            backgroundCave.Stop();
            backgroundFirst.Play();
            backgroundSecond.Stop();
        }
        else if (audioNumber == 2 && !backgroundSecond.isPlaying)
        {
            backgroundCave.Stop();
            backgroundFirst.Stop();
            backgroundSecond.Play();
        }
    }
}
