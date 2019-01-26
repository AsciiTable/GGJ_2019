using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jump;
    public bool arcadeMovement;

    //used for the AddForce Movement
    private Rigidbody2D rb2d;
    private bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        isGround = false;
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        //Used for the AddForce movement;
        //This code have a bug (transform.position.y) Do not know what it does specifically. Bug is if player jump a certain height it would go on forever.
        Vector2 movement = new Vector2(horizontal, transform.position.y);

        //Movement selection by the boolean
        if (arcadeMovement)
        {
            //y position have a bug
            transform.position += new Vector3(horizontal * speed, 0, transform.position.z);
        }
        else if (!arcadeMovement)
        {
            rb2d.AddForce(movement * speed);
        }

        if (Input.GetKeyDown("up") && isGround)
        {
            Debug.Log("Up is press");
            isGround = false;
            rb2d.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }
}
