using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sitSpot : MonoBehaviour
{
    public GameObject player;
    public float closeness; //Input Inspector: how close does player need to be
    public string type; //Input: What kind of interactable object is this?

    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance <= closeness)
        {
            if (Input.GetButtonDown("Interact"))
            {
                //Sit Next to Campfire
                if (type == "Campfire")
                {
                    
                }
            }
        }

    }
}
