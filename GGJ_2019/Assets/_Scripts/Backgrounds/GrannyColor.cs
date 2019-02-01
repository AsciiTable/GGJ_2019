using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrannyColor : MonoBehaviour
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

        if(worldStatus.GrandfatherClock == true)
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
            if (worldStatus.GrandfatherClock && change < 3)
            {
                timer += Time.deltaTime;
                animator.SetTrigger("addColor");
            }

            if (timer >= 2f && change == 0)
            {
                change++;
            }
            if (change == 1)
            {
                animator.enabled = false;
            }
        }
    }
}
