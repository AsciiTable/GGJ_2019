using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sitSpot : MonoBehaviour
{
    private UnityStandardAssets._2D.Platformer2DUserControl playerInput;

    public GameObject player;
    private WorldStatus worldStatus;
    public float closeness; //Input Inspector: how close does player need to be
    public string type; //Input: What kind of interactable object is this?

    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;

    private float sitTimer;
    private bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
        playerInput = GameObject.Find("Player").GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>();
        worldStatus = GameObject.FindGameObjectWithTag("ScriptHolder").GetComponent<WorldStatus>();

        if(type == "Campfire" && worldStatus.ForestBackground)
        {
            active = false;
            Destroy(this.gameObject);
        }
        if(type == "NightSky" && worldStatus.stars == true)
        {
            active = false;
        }

    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance <= closeness && playerInput.crouch)
        {
            sitTimer += Time.deltaTime;
        }
        else
        {
            sitTimer = 0f;
        }

        //if they sit for at least 8 seconds


        if(sitTimer >= 8f && active)
        {
            //Sit Next to Campfire
            if (type == "Campfire")
            {
                active = false;
                worldStatus.ForestBackground = true;
                worldStatus.livingRoom++;
                worldStatus.collection++;
            }
        }

        if (type == "NightSky" && playerInput.crouch && worldStatus.starReady)
        {
            worldStatus.starGaze = true;

            if(sitTimer >= 8f && active)
            {
                worldStatus.collection++;
                worldStatus.stars = true;
                active = false;
            }
        }
        if(!playerInput.crouch && worldStatus.starGaze)
        {
            worldStatus.stopGaze = true;
        }
        

    }
}
