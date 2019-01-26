using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public GameObject player;
    public float objectClosenesss;
    private Rigidbody2D rb2d;
    private Animator ChairAnim;

    private bool sitable = false;
    public bool sitting = false;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ChairAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Interact"))
        {
            if(sitting == true)
            {
                sitting = false;
            }
            else if(sitting == false)
            {
                sitting = true;
            }

            ChairAnim.SetTrigger("ToggleSit");
        }

        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance < objectClosenesss)
        {
            Debug.Log("Yes I am here");
            sitable = true;
        }
        else
        {
            sitable = false;
        }

        

    }
}
