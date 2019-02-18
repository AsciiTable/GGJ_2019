using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class sitSpot : MonoBehaviour
{
    private UnityStandardAssets._2D.Platformer2DUserControl playerInput;

    public GameObject player;
    private WorldStatus worldStatus; 
    public float closeness; //Input in Inspector: how close does player need to be
    public string type; //Input: What kind of interactable object is this?

    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;

    private float sitTimer;
    private bool active = true;
    private bool playedMusic = false;

    private bool playedFireBGM = false;
    
    private bool playedClockBGM = false;


    public AudioSource bgm; 

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
        playerInput = GameObject.Find("Player").GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>();
        worldStatus = GameObject.FindGameObjectWithTag("ScriptHolder").GetComponent<WorldStatus>();

        //Campfire Sit Collider disappears after the forest gets color
        if(type == "Campfire" && worldStatus.ForestBackground)
        {
            active = false;
        }
        if(type == "NightSky" && worldStatus.stars == true)
        {
            active = false;
            spriteRenderer.enabled = true;
        }


    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        
        //Checks if Player is at sit location and is sitting down
        if (distance <= closeness && playerInput.crouch)
        {
            //Plays campfire sound 
            if(type == "Campfire" && !playedMusic)
            {
                playedMusic = true; //Make sure audio doesn't play continuously 
                Audio.PlaySound("fire_crackle");
            }

            if (type == "NightSky")
            {
                if (!playedMusic)
                {
                    playedMusic = true; 
                    bgm.enabled = true;
                }
            }

            if (type == "Clock")
            {
                if (!playedMusic)
                {
                    Audio.PlaySound("grandfather_clock");
                    playedMusic = true;
                }
            }

            sitTimer += Time.deltaTime;
        }
        else
        {
            playedMusic = false; //Lets audio play again when you sit
            sitTimer = 0f;
        }

        //if they sit for at least 8 seconds (Universal Timer)
        if(sitTimer >= 8f && active)
        {
            if(type == "NightSky")
            {
                spriteRenderer.enabled = true;
                active = false;
                worldStatus.stars = true;
                worldStatus.collection++;
            }

            //Sit Next to Campfire for 8 seconds
            if (type == "Campfire")
            {
                if (!playedFireBGM)
                {
                    playedFireBGM = true; 
                    bgm.enabled = true;
                }

                active = false; //Stop Object from Changing
                worldStatus.ForestBackground = true; //Change background to color
                worldStatus.livingRoom++; //Work in Progress
                worldStatus.collection++; //Work in Progess
            }

            if (type == "Clock")
            {
                if (!playedClockBGM)
                {
                    playedClockBGM = true;
                    bgm.enabled = true;
                }
            }
        }


        if (type == "NightSky" && playerInput.crouch)
        {
            worldStatus.starGaze = true;
        }
        if (type == "Ending" && playerInput.crouch)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
