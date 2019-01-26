using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public bool arcadeMovement;

    //used for the AddForce Movement
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //Used for the AddForce movement;
        Vector2 movement = new Vector2(horizontal, vertical);

        //Movement selection by the boolean
        if (arcadeMovement)
        {
            transform.position += new Vector3(horizontal * speed, vertical * speed, transform.position.z);
        }
        else if (!arcadeMovement)
        {
            rb2d.AddForce(movement * speed);
        }
    }
}
