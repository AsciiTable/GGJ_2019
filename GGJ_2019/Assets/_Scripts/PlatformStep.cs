using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformStep : MonoBehaviour
{
    //public bool isPlayerOn;
    private PlatformEffector2D effector;
    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            effector.rotationalOffset = 0f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            effector.rotationalOffset = 180f;
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.tag == "Player")
    //    {
    //        isPlayerOn = true;
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        isPlayerOn = false;
    //    }
    //}
}
