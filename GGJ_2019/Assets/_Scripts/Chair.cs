using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public GameObject player;
    public float objectClosenesss;
    private Rigidbody2D rb2d;
    private Animator ChairAnim;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ChairAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Interact"))
        //{
        //    ChairAnim.SetTrigger("ToggleSit");
        //}

        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance <= objectClosenesss && Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Sit I do for I am here");
        }
    }
}
