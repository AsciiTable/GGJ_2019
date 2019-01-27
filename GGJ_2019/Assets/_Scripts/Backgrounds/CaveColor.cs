using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveColor : MonoBehaviour
{
    private WorldStatus worldStatus;
    private Animator animator;

    private float change = 0f;
    private float timer = 0;
    private bool activated = false;

    // Start is called before the first frame update
    void Start()
    {
        worldStatus = GameObject.FindGameObjectWithTag("ScriptHolder").GetComponent<WorldStatus>();
        animator = GetComponent<Animator>();

        if(worldStatus.CaveBackground == true)
        {
            activated = true;
            animator.SetTrigger("Done");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (activated == false)
        {
            if (worldStatus.CaveBackground && change < 3)
            {
                timer += Time.deltaTime;
            }

            if (timer >= 3f && change == 0)
            {
                change++;
                animator.SetTrigger("addTexture");
            }
            if (timer >= 6f && change == 1)
            {
                change++;
                animator.SetTrigger("addColor");
                animator.SetTrigger("Appear");


            }
            if (timer >= 8f && change == 2)
            {

                change++;

            }
            if (change == 3)
            {
                animator.enabled = false;

            }
        }
    }
}
