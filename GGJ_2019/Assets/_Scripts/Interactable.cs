using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private WorldStatus worldStatus;

    public GameObject player;
    public float closeness; //Input Inspector: how close does player need to be
    public string type; //Input: What kind of interactable object is this?

    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;

    private bool removeItem = false;
    public float fadeSpeed;
    private float opacityTime = 1f;

    public AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
        worldStatus = GameObject.FindGameObjectWithTag("ScriptHolder").GetComponent<WorldStatus>(); 


        if(type == "ToyHouse" && worldStatus.CaveBackground == true)
        {
            Destroy(this.gameObject);
            worldStatus.collection++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance <= closeness)
        {
            if (Input.GetButtonDown("Interact"))
            {
                //Interact with ToyHouse
                if(type == "ToyHouse")
                {
                    removeItem = true;
                    worldStatus.CaveBackground = true;
                    bgm.enabled = true;
                }
            }
        }


        if (removeItem == true)
        {
            boxCollider.enabled = false;

            if (opacityTime >= 0)
            {
                opacityTime -= Time.deltaTime * fadeSpeed;
            }
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, opacityTime);
        }

    }

}
