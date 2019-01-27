using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public static AudioClip BoilingWaterSFX;
    public static AudioClip DoorCloseSFX;
    public static AudioClip DoorOpenSFX;
    public static AudioClip FireCrackleSFX;
    public static AudioClip FootstepSFX;
    public static AudioClip GradfatherClockSFX;
    static AudioSource MusicSource;
	

    // Use this for initialization
    void Start ()
    {
        BoilingWaterSFX = Resources.Load<AudioClip>("boiling_water");
        DoorCloseSFX = Resources.Load<AudioClip>("door_close");
        DoorOpenSFX = Resources.Load<AudioClip>("door_open");
        FireCrackleSFX = Resources.Load<AudioClip>("fire_crackle");
        FootstepSFX = Resources.Load<AudioClip>("footstep");
        GradfatherClockSFX = Resources.Load<AudioClip>("grandfather_clock");
        MusicSource = GetComponent<AudioSource>();
    }
	
    // Update is called once per frame
    void Update () {
		
    }
	
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "boiling_water":
                MusicSource.PlayOneShot(BoilingWaterSFX);
                break;
			
            case "door_close":
                MusicSource.PlayOneShot(DoorCloseSFX);
                break;
			
            case "door_open":
                MusicSource.PlayOneShot(DoorOpenSFX);
                break;
			
            case "fire_crackle":
                MusicSource.PlayOneShot(FireCrackleSFX);
                break;
			
            case "footstep":
                MusicSource.PlayOneShot(FootstepSFX);
                break;
            
            case "grandfather_clock":
                MusicSource.PlayOneShot(GradfatherClockSFX);
                break;
			
            default:
                break;
        }
    }
}
