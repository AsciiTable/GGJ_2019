using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public static AudioClip BoilingWaterSFX;
    public static AudioClip DoorCloseSFX;
    public static AudioClip DoorOpenSFX;
    public static AudioClip FireCrackleSFX;
    public static AudioClip FootstepSFX;
    public static AudioClip GradfatherClockSFX;

    public static AudioClip OutOfCave;
    public static AudioClip Reminder;
    public static AudioClip BitsOfColor;
    public static AudioClip BitsOfSound;
    public static AudioClip ThisIsHome;
    public static AudioClip Rememberance;
    public static AudioClip Stargazing;
    
    static AudioSource MusicSource;
	

    // Use this for initialization
    void Start ()
    {
        //SFX
        BoilingWaterSFX = Resources.Load<AudioClip>("boiling_water");
        DoorCloseSFX = Resources.Load<AudioClip>("door_close");
        DoorOpenSFX = Resources.Load<AudioClip>("door_open");
        FireCrackleSFX = Resources.Load<AudioClip>("fire_crackle");
        FootstepSFX = Resources.Load<AudioClip>("footstep");
        GradfatherClockSFX = Resources.Load<AudioClip>("grandfather_clock");
        
        //BGM
        OutOfCave = Resources.Load<AudioClip>("outOfCave");
        Reminder = Resources.Load<AudioClip>("reminder");
        BitsOfColor = Resources.Load<AudioClip>("bitsOfColor");
        BitsOfSound = Resources.Load<AudioClip>("bitsOfSound");
        ThisIsHome = Resources.Load<AudioClip>("thisIsHome");
        Rememberance = Resources.Load<AudioClip>("rememberance");
        Stargazing = Resources.Load<AudioClip>("stargazing");
        
        
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
            
            case "outOfCave":
                MusicSource.PlayOneShot(OutOfCave);
                break;
            
            case "reminder":
                MusicSource.PlayOneShot(Reminder);
                break;
			
            case "bitsOfColor":
                MusicSource.PlayOneShot(BitsOfColor);
                break;
			
            case "bitsOfSound":
                MusicSource.PlayOneShot(BitsOfSound);
                break;
			
            case "thisIsHome":
                MusicSource.PlayOneShot(ThisIsHome);
                break;
			
            case "rememberance":
                MusicSource.PlayOneShot(Rememberance);
                break;
            
            case "stargazing":
                MusicSource.PlayOneShot(Stargazing);
                break;
            
            default:
                break;
        }
    }
}
